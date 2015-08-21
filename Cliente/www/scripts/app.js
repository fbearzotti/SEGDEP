var SSDApp = angular.module('SSDApp', [
  'ngRoute',
  'categoriasControllers'
]);

SSDApp.config(['$routeProvider',
  function ($routeProvider) {
    $routeProvider.
      when('/:categorias', {
        templateUrl: 'partials/categorias.html',
        controller: 'categoriasCtrl'
      }).
      when('/main/:main', {
        templateUrl: 'main.html',
        controller: 'categoriasCtrl'
      }).
      //when('/phones/:phoneId', {
      //  templateUrl: 'partials/phone-detail.html',
      //  controller: 'PhoneDetailCtrl'
      //}).
      otherwise({
        redirectTo: 'main.html'
      });
  }]);

