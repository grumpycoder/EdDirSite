/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var print = require('gulp-print').default;
var uglify = require('gulp-uglify');
var concat = require('gulp-concat');

gulp.task('default', function () {
    // place code for your default task here
});


// Fonts
gulp.task('fonts', function () {
    return gulp.src([
        'node_modules/@fortawesome/fontawesome-free/webfonts/**.*'])
        .pipe(print())
        .pipe(gulp.dest('/fonts'));
});

gulp.task('js', function () {
    gulp.src([
        'node_modules/jquery/dist/jquery.js',
        'node_modules/bootstrap/dist/js/bootstrap.bundle.js',
        'src/js/**/*.js'
    ])
        .pipe(print())
        .pipe(uglify())
        .pipe(concat('vendor.min.js'))
        .pipe(gulp.dest('js'));
});
