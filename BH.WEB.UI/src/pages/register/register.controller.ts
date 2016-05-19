export class RegisterController {
    public static $inject: Array<string> = [];

    public login: string;
    public email: string;
    public password: string;
    public confirmPassword: string;

    public errorMessage: string;

    constructor() {

    }

    public submit(): void {
        if (this.checkPasswords()) {

        } else {
            this.errorMessage = 'passwords are not equals';
        }
    }

    private checkPasswords(): boolean {
        if (this.password === this.confirmPassword) {
            return true;
        }
        else {
            return false;
        }
    }
}