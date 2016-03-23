import {TopBarDirective} from './topbar.directive';

angular
    .module('app.core.topbar', [])
    .directive('bhTopbar', TopBarDirective.create());