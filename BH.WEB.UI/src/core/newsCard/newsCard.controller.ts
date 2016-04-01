export class CardController {
    public static $inject: Array<string> = [
        '$scope',
        '$mdDialog',
        '$mdMedia',
    ];

    private _isFavorite: boolean;

    constructor(
        private _$scope: ng.IScope,
        private _$mdDialog: ng.material.IDialogService,
        private _$mdMedia: ng.material.IMedia
    ) {

    }

    public showNews(): any {
        // $mdMedia('xs') || $mdMedia('sm')

        this._$mdDialog.show({
            templateUrl: 'core/newsDialog/newsDialog.tpl.html',
            parent: angular.element(document.body),
            clickOutsideToClose: true,
        });
    }

    // public isFavorite(): void {
    //     this._isFavorite = !this._isFavorite;
    // }
}