import './templates/templates.module';
import './card/card.module';
import './topbar/topbar.module';
import './sidenav/sidenav.module';

import {configureStates} from './core.route';

angular
    .module('app.core', [
        'ui.router',
        'ngMaterial',

        'app.core.templates',
        'app.core.card',
        'app.core.topbar',
        'app.core.sidenav'

    ])
    .config(configureStates);