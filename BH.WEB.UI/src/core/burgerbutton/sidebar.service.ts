import {ISidebarService} from './ISidebarService';

export class RxSidebarService implements ISidebarService {
    private _visible: Rx.Subject<boolean>;

    constructor() {
        this._visible = new Rx.Subject<boolean>();
    }

    public next(value: boolean): void {
        this._visible.onNext(value);
    }

    public subscribe(next: Function): void {
        this._visible.subscribe((value: boolean) => next(value));
    }
}