'use strict';

myApp.controller('PillsCtrl', ['$scope','$location', function ($scope, $location) {
    $scope.Page = $location.path();

    console.log($scope.Page);
}]);