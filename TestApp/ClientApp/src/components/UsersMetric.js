import React, { Component } from 'react';
import DatePicker from 'react-datepicker'
import "react-datepicker/dist/react-datepicker.css";
import { registerLocale, setDefaultLocale } from "react-datepicker";
import axios from "axios";

import { BarChart, Bar, Cell, XAxis, YAxis, CartesianGrid } from 'recharts';
import ru from 'date-fns/locale/ru';
registerLocale('ru', ru);
setDefaultLocale('ru');

export class UsersMetric extends Component {
    static displayName = 'Пользователи';

    constructor(props) {
        super(props);
        this.state = { users: [], chartData: [], loading: true, isDiagramShown: false, isChartLoading: false };
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
                <h2>Rolling Retention 7 day</h2>
                <BarChart
                    width={500}
                    height={300}
                    data={data}
                    margin={{
                        top: 5,
                        bottom: 5
                    }}
                >
                    <CartesianGrid strokeDasharray="3 3" />
                    <XAxis dataKey="dateDiff" />
                    <YAxis />
                    <Bar dataKey="retentionRate" fill="#8884d8" />
                </BarChart>
            </div>
        );
    }

    renderUsersTable(users) {
        return (
            <div>
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
                                        onChange={date => this.handleUserChange({ ...user, dateRegistration: date })} />
                                </td>
                                <td>
                                    <DatePicker
                                        selected={new Date(user.dateLastActivity)}
                                        dateFormat="dd.MM.yyyy"
                                        onChange={date => this.handleUserChange({ ...user, dateLastActivity: date })} />
                                </td>
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

    //расчет rolling retention
    async calculate() {
        this.setState({ isChartLoading: true });
        const response = await fetch('rollingretention');
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
}
