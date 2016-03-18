export class CardDirective {
	public templateUrl: string = "core/card/card.tpl.html";
	constructor() { }

	public static create(): ng.IDirectiveFactory {
		let card = () => new CardDirective();
		card.$inject = [];
		return card;
	}
}