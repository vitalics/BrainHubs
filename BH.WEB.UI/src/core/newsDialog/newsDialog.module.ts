import { NewsDialogController } from './newsDialog.controller';
import { Dialog } from './newsDialog';

angular
    .module('app.core.dialog', [])
    .controller('NewsDialogController', NewsDialogController)
    .component('bhNewsDialog', new Dialog());