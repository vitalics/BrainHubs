import '../news/news.module';
import { CardController } from './card.controller';
import {CardDirective} from './card.directive';

angular
    .module('app.core.card', ['app.core.news'])
    .controller('CardController', CardController)
    .directive('bhNewsCard', CardDirective.create())