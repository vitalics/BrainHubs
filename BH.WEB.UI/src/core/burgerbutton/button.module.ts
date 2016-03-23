import '../topbar/topbar.module';

import { ButtonDirective } from './button.directive';
import { TopbarController} from './button.controller';


angular
    .module('app.core.button', [
        'app.core'
    ])
    .controller('TopbarController', TopbarController)
    .directive('bhBurgerButton', ButtonDirective.create());