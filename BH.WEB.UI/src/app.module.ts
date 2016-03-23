import './core/core.module';

import './pages/login/login.module';
import './pages/register/register.module';

import {configureStates} from './app.route';


angular
    .module('app', [

        'app.core',

        'app.pages.login',
        'app.pages.register'
    ])
    .config(configureStates);