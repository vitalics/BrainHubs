import {CardDirective} from './card.directive'

angular
	.module('app.core.card', ['app.core'])
	.directive('bhNewsCard', CardDirective.create())