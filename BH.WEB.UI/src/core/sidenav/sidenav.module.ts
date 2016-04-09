import { Sidenav } from './sidenav';
import { SidenavController } from './sidenav.controller';

angular
    .module('app.core.sidenav', [])
    .controller('SidenavController', SidenavController)
    .component('bhSidenav', new Sidenav());