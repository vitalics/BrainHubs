import './templates/templates.module';
import './card/card.module';
angular
	.module('app.core', [
		'app.core.templates',
		'app.core.card',
	]);