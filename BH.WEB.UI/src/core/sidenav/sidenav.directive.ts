export class SidenavDirective {
    public templateUrl: string = "core/sidenav/sidenav.tpl.html";

    constructor() { }

    public static create(): ng.IDirectiveFactory {
        let sidenav = () => new SidenavDirective();
        sidenav.$inject = [];
        return sidenav;
    }
}