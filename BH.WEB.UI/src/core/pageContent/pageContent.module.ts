import '../card/card.module';
import '../sidenav/sidenav.module';

import { PageContentDirective } from './pageContent.directive';

angular
    .module('app.core.content', [
        'app.core.sidenav',
        'app.core.card'
    ])
    .directive('bhPageContent', PageContentDirective.create());