export class PageContentDirective {
    public templateUrl: string = "core/pageContent/pageContent.tpl.html";
    constructor() { }
    public static create(): ng.IDirectiveFactory {
        let pageContent = () => new PageContentDirective();
        pageContent.$inject = [];
        return pageContent;
    }
}