import './templates/templates.module';
import './topbar/topbar.module';
import './pageContent/pageContent.module';


import {configureStates} from './core.route';

angular
    .module('app.core', [
        'ui.router',
        'ngMaterial',
        'angular.filter',

        'app.core.templates',
        'app.core.topbar',
        'app.core.content',
    ])
    .config(configureStates);