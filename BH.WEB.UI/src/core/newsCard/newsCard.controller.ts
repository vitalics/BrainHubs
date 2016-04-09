export class CardController {
    public static $inject: Array<string> = [
        '$mdDialog',
        '$mdMedia',
    ];

    public id: string;
    public title: string;
    public tags: string[];
    public text: string;

    constructor(
        private _$mdDialog: ng.material.IDialogService,
        private _$mdMedia: ng.material.IMedia
    ) {

    }

    public tagClick(tag: string) {
        console.log(tag);
    }

    public showNews(id: string): ng.IPromise<any> {
        // $mdMedia('xs') || $mdMedia('sm')
        return this._$mdDialog.show({
            templateUrl: 'core/newsDialog/newsDialog.tpl.html',
            parent: angular.element(document.body),
            clickOutsideToClose: true,
        });
    }

    // public isFavorite(): void {
    //     this._isFavorite = !this._isFavorite;
    // }
}