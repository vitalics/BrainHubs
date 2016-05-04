export class CardController {
    public static $inject: Array<string> = [
        '$mdDialog',
    ];

    public id: string;
    public title: string;
    public tags: string[];
    public text: string;
    public categories: string[];
    public callback: Function

    constructor(
        private _$mdDialog: ng.material.IDialogService
    ) { }
    public tagClick(): void {
        this.callback({
            sortedString: 'tags'
        });
    }
    public categoriesClick() {
        this.callback({
            sortedString: 'categories'
        });
    }
    public showNews(): ng.IPromise<any> {
        let news = this._$mdDialog.alert()
            .title(this.title)
            .textContent(this.text)
            .clickOutsideToClose(true)
            .ok('cancel')
            .ok('OK');
        let showNews = this._$mdDialog.show(news);
        return showNews;
    }
}
