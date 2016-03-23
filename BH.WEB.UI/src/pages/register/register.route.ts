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
            state: 'register',
            config: {
                url: '/register',
                templateUrl: 'pages/register/register.tpl.html',
                controller: 'RegisterController',
                controllerAs: 'vm',
                title: 'register',
            }
        }
    ];
}