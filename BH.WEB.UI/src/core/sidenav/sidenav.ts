export class Sidenav implements ng.IComponentOptions {
    public controller: string = 'SidenavController';
    public templateUrl: string = 'core/sidenav/sidenav.tpl.html';
    public bindings: any = {
        callback: '&'
    };
}