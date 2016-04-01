import '../burgerbutton/button.module';

import {TopBarDirective} from './topbar.directive';
import { TopbarController } from './topbar.controller';


angular
    .module('app.core.topbar', ['app.core.button'])
    .controller('TopbarController', TopbarController)
    .directive('bhTopbar', TopBarDirective.create());