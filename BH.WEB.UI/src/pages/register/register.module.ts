import '../../core/core.module';
import '../../core/topbar/topbar.module'

import { configureStates } from './register.route';
import { RegisterController } from './register.controller';

angular
    .module('app.pages.register', ['app.core'])
    .controller('RegisterController', RegisterController)
    .config(configureStates);