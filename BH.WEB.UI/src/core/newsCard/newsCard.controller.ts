export class CardController {
    public static $inject: Array<string> = [
        '$mdDialog',
        '$mdMedia',
    ];

    public id: string;
    public title: string;
    public tags: string[];
    public text: string;
    public categories: string[];

    constructor(
        private _$mdDialog: ng.material.IDialogService,
        private _$mdMedia: ng.material.IMedia
    ) {

    }

    public tagClick(tag: string) {
        console.log(tag);
    }

    public showNews(): ng.IPromise<any> {

        let news = this._$mdDialog.alert()
            .title(this.title)
            .textContent(this.text)
            .ok("OK")
            .clickOutsideToClose(true);

        let showNews = this._$mdDialog.show(news).finally(() => {
            news = undefined;
        });
        console.log("news id" + this.id);
        return showNews;
        // $mdMedia('xs') || $mdMedia('sm')
    }
}