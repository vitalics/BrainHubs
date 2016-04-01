
import { ButtonDirective } from './button.directive';
import { TopbarController} from './button.controller';


angular
    .module('app.core.button', [])
    .controller('TopbarController', TopbarController)
    .directive('bhBurgerButton', ButtonDirective.create());