
import {TopBarDirective} from './topbar.directive';
import { TopbarController } from './topbar.controller';


angular
    .module('app.core.topbar', [])
    .controller('TopbarController', TopbarController)
    .directive('bhTopbar', TopBarDirective.create());