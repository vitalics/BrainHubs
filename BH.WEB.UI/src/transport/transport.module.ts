import { NewsRepository } from './newsRepository';

angular
    .module('app.transport.newsRepository', [])
    .service('NewsRepository', NewsRepository);