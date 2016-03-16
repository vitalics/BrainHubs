import {CardDirective} from './card.directive'

angular
	.module('app.core.card', [])
	.directive('bhNewsCard', CardDirective.create())