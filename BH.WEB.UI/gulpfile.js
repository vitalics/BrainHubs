var gulp = require("gulp");
var templateCache = require('gulp-angular-templatecache');
var sass = require('gulp-sass');

gulp.task('templatecache', function() {
    return gulp
        .src(config.htmltemplates)
        .pipe(templateCache(
            config.templateCache.file,
            config.templateCache.options
		))
        .pipe(gulp.dest(config.temp));
});

gulp.task('sass', function() {
    gulp.src('./src/app.scss')
        .pipe(sass())
        .pipe(gulp.dest('./build'));
});

gulp.task('sass:watch', function () {
    gulp.watch('./src/**/*.scss', ['sass']);
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