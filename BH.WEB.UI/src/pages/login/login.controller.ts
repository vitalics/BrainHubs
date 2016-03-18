export class LoginController {
	public static $inject: Array<string> = [];

	public login: string;
	public password: string;

	constructor() {

	}

	public submit(): void {
		console.log(this.login, this.password);
	}
}