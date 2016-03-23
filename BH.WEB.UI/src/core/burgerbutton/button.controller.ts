import {ISidebarService} from './ISidebarService';

export class TopbarController {
    public static $inject: Array<string> = ['RxSidebarService'];
    private _isSidebarVisible: boolean;

    constructor(
        private _rxSidebarService: ISidebarService
    ) { }

    public burgerClick(): void {
        this._isSidebarVisible = !this._isSidebarVisible;
        this._rxSidebarService.next(this._isSidebarVisible);
    }
}