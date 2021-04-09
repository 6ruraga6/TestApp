import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';

import './custom.css'
import { UsersMetric } from './components/UsersMetric';

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={UsersMetric} />
            </Layout>
        );
    }
}
