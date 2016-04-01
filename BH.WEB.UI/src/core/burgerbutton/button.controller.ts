import {ISidebarService} from './ISidebarService';

export class TopbarController {
    public static $inject: Array<string> = ['RxSidebarService', '$mdSidenav'];
    private _isSidebarVisible: boolean;

    constructor(
        private _rxSidebarService: ISidebarService,
        private _$mdSidenav: ng.material.ISidenavService
    ) { }

    public burgerClick(): void {
        this._isSidebarVisible = !this._isSidebarVisible;
        this._rxSidebarService.next(this._isSidebarVisible);
    }

    public toggleMenu(): void {
        this._$mdSidenav('left').open();
    }
}
