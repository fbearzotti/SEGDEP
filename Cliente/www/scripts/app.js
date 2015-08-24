var SSDApp = angular.module('SSDApp', [
  'ngRoute',
  'categoriasControllers'
]);

$(document).ready(function () {
  inicializoMenu();
});


//SSDApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
//  $routeProvider.
//      when('/categorias', {
//        templateUrl: 'partials/categorias.html',
//        controller: 'categoriasCtrl'
//      }).
//      when('/login', {
//        redirectTo: 'login.html'
//      }).
//      otherwise({
//        redirectTo: 'main.html'
//      });
//}]);

SSDApp.config(['$routeProvider',
  function ($routeProvider) {
    $routeProvider.
      when('/categorias', {
        templateUrl: 'partials/categorias.html',
        controller: 'categoriasCtrl'
      }).
      when('/login', {
        redirectTo: 'login.html'
      }).
      //when('/phones/:phoneId', {
      //  templateUrl: 'partials/phone-detail.html',
      //  controller: 'PhoneDetailCtrl'
      //}).
      otherwise({
        redirectTo: 'main.html'
      });
  }]);

function inicializoMenu() {
  FooNav.init({
    classes: 'fon-rounded fon-shadow',
    continer: '#mi_menu',
    position: 'fon-top-right',
    theme: 'fon-light',
    items: [{
      href: 'main.html',
      text: 'Principal'
    },
    {
      href: '#categorias',
      text: 'Listado Categorias'
    },
    {
      href: '#entrenamientos',
      text: 'Entrenamientos',
      children: [{
        href: 'main.html?categorias',
        text: 'Listado Entrenamientos',
      }, {
        href: 'main.html?categorias',
        text: 'Toma de Presentismo'
      }]
    },
    {
      href: 'main.html#/login',
      text: 'Ingreso al sistema'
    }]
  });

}


