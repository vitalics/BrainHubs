export class RegisterController {
    public static $inject: Array<string> = [];

    public login: string;
    public email: string;
    public password: string;
    public confirmPassword: string;

    constructor() {

    }

    public submit(): void {
        if (this.password == this.confirmPassword) {
            console.log(this.email, this.login, this.password);
        }
        else {
            console.log('passwords must be coincide');
        }
    }
}