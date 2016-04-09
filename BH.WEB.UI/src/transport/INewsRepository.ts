export interface INewsRepository {
    getNews(): ng.IPromise<any[]>;
    getTags(): ng.IPromise<string[]>
}
