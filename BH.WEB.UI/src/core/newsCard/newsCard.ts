export class Card {
    public templateUrl: string = "core/newsCard/newsCard.tpl.html";
    public controller: string = "CardController";
    public bindings: any = {
        id: '<',
        title: '<',
        categories: '<',
        tags: '<',
        text: '<',
        callback: '&'
    };
}