import React, { Component } from 'react';
import DatePicker from 'react-datepicker'
import "react-datepicker/dist/react-datepicker.css";
import { registerLocale, setDefaultLocale } from "react-datepicker";
import axios from "axios";
import moment from "moment";

import { BarChart, Bar, Cell, XAxis, YAxis, CartesianGrid } from 'recharts';
import ru from 'date-fns/locale/ru';
registerLocale('ru', ru);
setDefaultLocale('ru');

export class UsersMetric extends Component {
    static displayName = 'Пользователи';

    constructor(props) {
        super(props);
        this.state = { users: [], chartData: [], rollingRetention: 0, loading: true, isDiagramShown: false, isChartLoading: false };
    }

    //изменение списка пользователей
    handleUserChange(user) {
        const newList = this.state.users.map((item) => {
            if (item.userId === user.userId) {
                return user;
            }
            return item;
        });

        this.setState({ users: newList, loading: false });
    }

    componentDidMount() {
        this.populateUsersData();
    }

    //отрисовка диаграммы
    renderChart(data) {
        return (
            <div>
                <p>Rolling Retention 7 day - {this.state.rollingRetention}%</p>
                <BarChart
                    width={500}
                    height={300}
                    data={data}
                    margin={{
                        top: 30,
                        left: 30,
                        right: 100,
                        bottom: 5
                    }}
                >
                    <CartesianGrid strokeDasharray="3 3" />
                    <XAxis label={{ value: "Life time, days", position: 'right', offset: 0 }} dataKey="days" />
                    <YAxis label={{ value: "User's count", position: 'top', offset: 10 }} />
                    <Bar dataKey="usersCount" fill="#8884d8" />
                </BarChart>
            </div>
        );
    }

    renderUsersTable(users) {
        return (
            <div>
                <button className="btn" onClick={ev => this.addUser()}>Add user</button>
                <table className='table' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>UserID</th>
                            <th>Date Registration</th>
                            <th>Date Last Activity</th>
                        </tr>
                    </thead>
                    <tbody>
                        {users.map(user =>
                            <tr key={user.userId}>
                                <td>{user.userId}</td>
                                <td>
                                    <DatePicker
                                        selected={new Date(user.dateRegistration)}
                                        dateFormat="dd.MM.yyyy"
                                        onChange={date => {
                                            var newDate = moment(date, "dd.MM.yyyy").startOf('day').format();
                                            this.handleUserChange({ ...user, dateRegistration: newDate })
                                        }
                                        } />
                                </td>
                                <td>
                                    <DatePicker
                                        strictParsing
                                        selected={new Date(user.dateLastActivity)}
                                        dateFormat="dd.MM.yyyy"
                                        onChange={date => {
                                            var newDate = moment(date, "dd.MM.yyyy").startOf('day').format();
                                            this.handleUserChange({ ...user, dateLastActivity: newDate })
                                        }} />
                                </td>
                                <td><button className="btn" onClick={ev => this.deleteUser(user.userId)}>Delete</button></td>
                            </tr>
                        )}
                    </tbody>
                </table>

                <button className="btn btn-primary" onClick={this.saveData.bind(this)}>Save</button>
                <button className="btn btn-primary ml-1" onClick={this.calculate.bind(this)}>Calculate</button>
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderUsersTable(this.state.users);

        return (
            <div className="container">
                {contents}
                <div className="mt-3 mb-3">
                    {
                        this.state.isChartLoading
                            ? <div>Loading...</div>
                            :
                            this.state.isDiagramShown
                                ? this.renderChart(this.state.chartData)
                                : <div />
                    }
                </div>
            </div>
        );
    }

    async get7DayRollingRetention() {
        await axios.get("rollingretention").then(response => this.setState({ rollingRetention: response.data })).catch(err => console.log(err));
    }

    async calculate() {
        this.get7DayRollingRetention();
        this.setState({ isChartLoading: true });
        const response = await fetch('userslifetime');
        const data = await response.json();
        this.setState({ chartData: data, isDiagramShown: true, isChartLoading: false });
    }

    //получение списка пользователей
    async populateUsersData() {
        const response = await fetch('users');
        const data = await response.json();
        this.setState({ users: data, loading: false });
    }

    //сохранение изменений пользователей в БД
    async saveData() {
        await axios.put('users', this.state.users).then(() => console.log('ok')).catch(err => console.log(err));
    }

    async deleteUser(userId) {
        console.log('users/' + userId);
        await axios.delete('users/' + userId)
            .then(() => {
                this.setState({ users: this.state.users.filter((user) => user.userId !== userId) })
            })
            .catch(err => console.log(err));
    }

    async addUser() {
        await axios.post('users').then((response) => this.setState({ users: response.data, loading: false })).catch(err => console.log(err));
    }
}
