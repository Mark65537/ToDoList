/// <binding ProjectOpened='sass' />
"use strict";

var gulp = require("gulp")
const sass = require('gulp-sass')(require('sass'));

var paths = {
    webroot: "./wwwroot/"
};

// регистрируем задачу для конвертации файла scss в css
gulp.task("sass", function () {
    return gulp.src(paths.webroot+'Sass/site.scss')
        .pipe(sass())
        .pipe(gulp.dest(paths.webroot + '/css'));
});
gulp.watch(paths.webroot + 'Sass/site.scss', function () {    
    return gulp.src(paths.webroot + 'Sass/site.scss')
        .pipe(sass())
        .pipe(gulp.dest(paths.webroot + '/css'));
    console.log('Sass changed');
});