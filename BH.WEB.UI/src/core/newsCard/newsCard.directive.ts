export class CardDirective {
    public templateUrl: string = "core/newsCard/newsCard.tpl.html";
    public controller: string = "CardController";
    public controllerAs: string = "ctrl";
    // public scope = {
    //     newsId: '<',
    //     title: '<',
    //     content: '<',
    //     imageUrl: '<'
    // }
    //public bindToController: boolean = true;

    constructor() { }

    public static create(): ng.IDirectiveFactory {
        let card = () => new CardDirective();
        card.$inject = [];
        return card;
    }
}