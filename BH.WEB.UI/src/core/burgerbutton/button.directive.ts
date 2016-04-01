export class ButtonDirective {
    public templateUrl: string = "core/burgerbutton/button.tpl.html";

    public controller: 'ButtonController';
    public controllerAs: 'vm';
    constructor() { }
    public static create(): ng.IDirectiveFactory {
        let button = () => new ButtonDirective();
        button.$inject = [];
        return button;
    }
}