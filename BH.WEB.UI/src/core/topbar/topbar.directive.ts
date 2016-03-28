export class TopBarDirective {
    public templateUrl: string = "core/topbar/topbar.tpl.html";
    public controller: string = "TopbarController";
    public controllerAs: string = 'ctrl';
    constructor() { }

    public static create(): ng.IDirectiveFactory {
        let topbar = () => new TopBarDirective();
        topbar.$inject = [];
        return topbar;
    }
}