export class TopbarController {
    public static $inject: Array<string> = ['$mdSidenav'];

    public contoller: string = "TopbarController";
    public controllerAs: string = "ctrl";

    constructor(private _$mdSidenav: ng.material.ISidenavService) {
    }

    public toggleMenu(): void {
        this._$mdSidenav('left').toggle();
    }
}