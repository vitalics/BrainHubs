export class CardDirective {
    public templateUrl: string = "core/card/card.tpl.html";
    public controller: string = "CardController";
    public controllerAs: string = "ctrl";
    constructor() { }

    public static create(): ng.IDirectiveFactory {
        let card = () => new CardDirective();
        card.$inject = [];
        return card;
    }
}