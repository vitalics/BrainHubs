import { INewsRepository } from './INewsRepository';

export class NewsRepository implements INewsRepository {
    public static $inject: Array<string> = [
        '$http',
        '$q',
        '$timeout'
    ];

    private _news: any[] = [
        {
            id: '12355453',
            title: 'test title',
            tags: ['tag1', 'tag2', 'tag3'],
            text: 'qweq weuiqwh  qwehiqheiqhu ehq uieiq uihiq uwehq ieiq heiq ieuiqwh',

        },
        {
            id: '1577954955',
            title: 'test title 2222',
            tags: ['tag4', 'tag5', 'tag6'],
            text: 'LOLOLOLOLO djfvblkvlskv fwsnvlsjnvlafhl',
        }
    ];

    private _tags: string[] = ["tag1", "tag2", "tag3", "tag4", "tag5", "tag6", "tag7", "tag8", "tag9"];

    constructor(
        private _$http: ng.IHttpService,
        private _$q: ng.IQService,
        private _$timeout: ng.ITimeoutService
    ) {
    }

    public getNews(): ng.IPromise<any[]> {
        let deffer = this._$q.defer();

        this._$timeout(() => {
            deffer.resolve(this._news);
        });

        return deffer.promise;
    }

    public getTags(): ng.IPromise<string[]> {
        let deffer = this._$q.defer();

        this._$timeout(() => {
            deffer.resolve(this._tags);
        });

        return deffer.promise;
    }
}