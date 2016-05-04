import { INewsRepository } from '../../transport/INewsRepository';

export class SidenavController {
    public static $inject: string[] = [
        'NewsRepository'
    ];

    public categories: string[];
    public callback: Function;

    constructor(
        private _newsRepository: INewsRepository
    ) {
        this._newsRepository.getTags().then((categories) => {
            this.categories = categories;
        });
    }

    public categoriesClick(): void {
        this.callback({
            sortedstring: 'categories'
        });
    }
}