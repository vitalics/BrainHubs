import '../burgerbutton/button.module';

import {Topbar} from './topbar';
import { TopbarController } from './topbar.controller';


angular
    .module('app.core.topbar', ['app.core.button'])
    .controller('TopbarController', TopbarController)
    .component('bhTopbar', new Topbar());