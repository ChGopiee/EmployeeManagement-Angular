module.exports = function (grunt) {
    grunt.initConfig({
        sync: {
            main: {
                files: [
                    {
                        cwd: 'Dist',
                        src: ['**/*.*'],
                        dest: '../EmployeeManagementSystem/EmployeeManagementAngular'
                    },
                ],
                verbose: true, // Default: false 
                pretend: false, // Don't do any disk operations - just write log. Default: false 
                failOnError: true, // Fail the task when copying is not possible. Default: false 
                ignoreInDest: "none", // Never remove js files from destination. Default: none 
                updateAndDelete: true, // Remove all files from dest that are not found in src. Default: false 
                compareUsing: "mtime" // compares via md5 hash of file contents, instead of file modification time. Default: "mtime" 

            }
        },
        watch: {
            copyFiles: {
                files: [
                     'Dist/**/*.*'
                ],
                tasks: ['sync'],
                options: {
                    event: ['all'],
                    livereload: 12345
                }
            }
        },
        copy: {
            main: {
                files: [
                    {
                        expand: true,
                        cwd: 'Dist',
                        src: ['**/*.*'],
                        dest: '../EmployeeManagementSystem/EmployeeManagementAngular'
                    }
                ]
            },
        },

    });


    grunt.loadNpmTasks('grunt-sync');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.registerTask('default', ['sync', 'watch']);
}