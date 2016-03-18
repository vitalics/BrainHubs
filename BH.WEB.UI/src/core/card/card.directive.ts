export class CardDirective {
	public templateUrl: string = "core/card/card.html";
	constructor() { }

	public static create(): ng.IDirectiveFactory {
		let card = () => new CardDirective();
		card.$inject = [];
		return card;
	}
}