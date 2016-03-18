configureStates.$inject = ['$stateProvider'];

export function configureStates(
	$stateProvider: ng.ui.IStateProvider) {

	let states = getStates();
	states.forEach(function(state) {
		$stateProvider.state(state.state, state.config);
	});
}

function getStates() {
	return [
		{
			state: 'app',
			config: {
				url: '/',
				templateProvider: ($templateCache: ng.ITemplateCacheService) => {
					return $templateCache.get('../index.html');
				},
				controller: ()=>{
					
				},
				title: 'app',
			}
		}
	];
}