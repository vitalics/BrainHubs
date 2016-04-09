import { INewsRepository } from '../../transport/INewsRepository';

export class SidenavController {
    public static $inject: string[] = [
        'NewsRepository'
    ];

    public tags: string[];

    constructor(
        private _newsRepository: INewsRepository
    ) {
        this._newsRepository.getTags().then((tags) => {
            this.tags = tags;
        });
    }

    public tagClick(tag: string) {
        console.log(tag);
    }
}