import './templates/templates.module';
import './card/card.module';

import {configureStates} from './core.route';

angular
	.module('app.core', [
		'ui.router',

		'app.core.templates',
		'app.core.card',
	])
	.config(configureStates);