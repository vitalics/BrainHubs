import { NewsTags } from './newsTags.directive';
angular
    .module('app.core.tags', [])
    .directive('bhTags', NewsTags.create());