import {TopBarDirective} from './topbar.directive';

angular
	.module('app.core.topbar', ['app.core'])
	.directive('bhTopbar', TopBarDirective.create());