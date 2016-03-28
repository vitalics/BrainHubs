export class TopbarController {
    public static $inject: Array<string> = ['$mdSidenav'];

    constructor(private _$mdSidenav: any) {
    }

    public isOpenMenut(): any {
        return this._$mdSidenav('right').isOpen();
    }
    public toggeMenu(): any {
        return this._$mdSidenav('right').toggle();
    }
}