export class CardController {
    public static $inject: Array<string> = [
        '$scope',
        '$mdDialog',
        '$mdMedia',
    ];

    constructor(
        private _$scope: ng.IScope,
        private _$mdDialog: ng.material.IDialogService,
        private _$mdMedia: ng.material.IMedia
    ) {

    }

    public showNews(): any {
        // $mdMedia('xs') || $mdMedia('sm')

        this._$mdDialog.show({
            controller: DialogController,
            templateUrl: 'core/news/news.tpl.html',
            parent: angular.element(document.body),
            clickOutsideToClose: true,
        });

        function DialogController(): any {
            // this._$mdDialog.hide();
            // this._$mdDialog.cancel();
        }
    }
}