export class NewsTags {
    public templateUrl: string = "core/newsTags/newsTags.tpl.html";

    constructor() { }

    public static create(): ng.IDirectiveFactory {
        let tags = () => new NewsTags();
        tags.$inject = [];
        return tags;
    }
}