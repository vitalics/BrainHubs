import {SidenavDirective} from './sidenav.directive';

angular
    .module('app.core.sidenav', [])
    .directive('bhSidenav', SidenavDirective.create());