import '../../core/core.module';
import '../../core/topbar/topbar.module'

import {configureStates} from './login.route';
import {LoginController} from './login.controller';
import {LoginDirective} from './login.directive';

angular
    .module('app.pages.login', [
        'app.core'

    ])
    .controller('LoginController', LoginController)
    .directive('bh-login', LoginDirective.create)
    .config(configureStates);