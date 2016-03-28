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
            state: 'login',
            config: {
                url: '/login',
                templateUrl: 'pages/login/login.tpl.html',
                controller: 'LoginController',
                controllerAs: 'vm',
                title: 'login',
            }
        }
    ];
}