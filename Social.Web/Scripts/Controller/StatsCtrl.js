'use strict';

myApp.controller('StatsCtrl', ['$scope', 'WebAPI', '$upload', function ($scope, WebAPI, $upload) {
    $scope.Test = "Stats";

    $scope.onFileSelect = function ($files) {
        //$files: an array of files selected, each file has name, size, and type.
        for (var i = 0; i < $files.length; i++) {
            var $file = $files[i];
            $upload.upload({
                url: 'api/FileUpload/',
                file: $file,
                progress: function (e) { }
            }).then(function (data, status, headers, config) {
                // file is uploaded successfully
                console.log(data);
            });
        }
    }


}]);