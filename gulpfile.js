/// <binding ProjectOpened='sass' />
"use strict";
//import gulpSass from "gulp-sass";
//import nodeSass from "node-sass";

//const sass = gulpSass(nodeSass);

var gulp = require("gulp")
const sass = require('gulp-sass')(require('sass'));
/*    sass = require("gulp-sass"); // добавляем модуль sass*/

var paths = {
    webroot: "./wwwroot/"
};
// регистрируем задачу для конвертации файла scss в css
gulp.task("sass", function () {
    return gulp.src(paths.webroot+'Sass/site.scss')
        .pipe(sass())
        .pipe(gulp.dest(paths.webroot + '/css'));
});

//gulp.task('watch', function () {//Слежение за Sass-файлами
//    gulp.watch(path.webroot +'Sass/site.scss', ['sass']);
//    // Другие отслеживания
//})