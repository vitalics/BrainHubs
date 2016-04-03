import '../newsDialog/newsDialog.module';
import {CardController} from './newsCard.controller';
import {CardDirective} from './newsCard.directive';

angular
    .module('app.core.card', ['app.core.dialog'])
    .controller('CardController', CardController)
    .directive('bhNewsCard', CardDirective.create())