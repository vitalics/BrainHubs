import {LoginController} from './login.controller';
import { configureStates } from './login.route';

angular
    .module('app.pages.login', [])
    .controller('LoginController', LoginController)
    .config(configureStates);