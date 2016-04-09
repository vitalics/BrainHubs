import { INewsRepository } from '../../transport/INewsRepository';

export class PageContentController {
    public static $inject: Array<string> = [
        'NewsRepository',
        '$timeout'
    ];

    public news: any[];

    constructor(
        private _newsRepository: INewsRepository,
        private _$timeout: ng.ITimeoutService
    ) {
        this._newsRepository.getNews().then((news) => {
            this.news = news;
            console.log("This is news!");
            _$timeout();
        });
    }
}