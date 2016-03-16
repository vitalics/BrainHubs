var gulp = require("gulp");
var templateCache = require('gulp-angular-templatecache');

gulp.task('templatecache', function () {
    return gulp
        .src(config.htmltemplates)
        .pipe(templateCache(
            config.templateCache.file,
            config.templateCache.options
            ))
        .pipe(gulp.dest(config.temp));
});

gulp.task('default', ['templatecache'])

var config = {
    htmltemplates: 'src/**/*.html',
    templateCache: {
        file: 'templates.js',
        options: {
            module: 'app.core.templates',
            standAlone: false
            //root: '/',
        }
    },
    temp: './build/'
};