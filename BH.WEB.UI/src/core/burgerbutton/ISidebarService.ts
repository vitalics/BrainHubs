export interface ISidebarService {
    next(value: boolean): void;
    subscribe(next: Function): void
}