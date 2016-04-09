import '../newsCard/newsCard.module';
import '../sidenav/sidenav.module';

import { PageContentController } from './pageContent.contoller';
import { PageContent } from './pageContent';

angular
    .module('app.core.content', [
        'app.core.sidenav',
        'app.core.card',
    ])
    .controller('PageContentController', PageContentController)
    .component('bhPageContent', new PageContent());
