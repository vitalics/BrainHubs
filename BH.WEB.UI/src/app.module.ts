import './core/core.module';

import './pages/login/login.module';

import {configureStates} from './app.route';


angular
	.module('app', [
		
		'app.core',
		
		'app.pages.login',
	])
	.config(configureStates);