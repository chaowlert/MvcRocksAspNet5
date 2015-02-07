﻿/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {
	grunt.initConfig({
		bower: {
			install: {
				options: {
					targetDir: "wwwroot/lib",
					layout: "byType",
					cleanTargetDir: false
				}
			}
		},
		uglify: {
			dist: {
				files: [{
					expand: true,
					src: '**.js',
					dest: 'wwwroot/lib/js/site',
					cwd: 'Assets/Scripts'
				}]
			}
		},
		scss: {
			dist: {
				files: {
					'wwwroot/lib/css/site.css': 'Assets/Styles/hw.scss'
				}
			}
		}
	});

	// This command registers the default task which will install bower packages into wwwroot/lib
	grunt.registerTask("default", ["bower:install"]);

	// The following line loads the grunt plugins.
	// This line needs to be at the end of this this file.
	grunt.loadNpmTasks("grunt-bower-task");
	grunt.loadNpmTasks("grunt-contrib-uglify");
	grunt.loadNpmTasks("grunt-contrib-scss");
};