/// <binding ProjectOpened='consul' />
'use strict';

var gulp = require('gulp');
var exec = require('child_process').exec;


gulp.task('consul', function () {
  //console.log(__dirname + '\\consul.exe agent -dev');
  exec(__dirname+'\\consul.exe agent -dev', function (err, stdout, stderr) {
    console.log(stdout);
    console.log(stderr);
    console.log(err);
  });
});
