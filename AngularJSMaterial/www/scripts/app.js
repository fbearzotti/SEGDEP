var app = angular.module('SSDApp', ['ngMaterial']);

app.config(function ($mdThemingProvider) {
  $mdThemingProvider.theme('default')
    .primaryPalette('indigo')
    .accentPalette('orange');
});

app.controller('AppCtrl', ['$scope', '$mdSidenav', function ($scope, $mdSidenav) {
  $scope.toggleSidenav = function (menuId) {
    $mdSidenav(menuId).toggle();
  };

}]);