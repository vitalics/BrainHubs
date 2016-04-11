import { INewsRepository } from '../../transport/INewsRepository';

export class SidenavController {
    public static $inject: string[] = [
        'NewsRepository'
    ];

    public categories: string[];

    constructor(
        private _newsRepository: INewsRepository
    ) {
        this._newsRepository.getTags().then((categories) => {
            this.categories = categories;
        });
    }

    public categoriesClick(categories: string) {
        console.log(categories);
    }
}