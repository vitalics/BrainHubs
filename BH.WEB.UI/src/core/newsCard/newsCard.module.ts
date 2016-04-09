import '../newsDialog/newsDialog.module';
import {CardController} from './newsCard.controller';
import {Card} from './newsCard';

angular
    .module('app.core.card', ['app.core.dialog'])
    .controller('CardController', CardController)
    .component('bhNewsCard', new Card())