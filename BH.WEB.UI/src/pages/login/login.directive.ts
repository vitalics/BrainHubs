export class LoginDirective {
	public templateUrl: string = "pages/login/login.tpl.html";
	constructor() { }

	public static create(): ng.IDirectiveFactory {
		let login = () => new LoginDirective();
		login.$inject = [];
		return login;
	}
}