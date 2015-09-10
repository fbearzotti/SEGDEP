﻿//var app = angular.module('SSDApp', ['ngRoute', 'ngMaterial', 'categoriasControllers']);
var app = angular.module('SSDApp', ['ngMaterial', 'categoriasControllers']);

// 192.168.1.138
//var servidorOdata = 'http://192.168.1.138/SSDREST/odata/'
var servidorOdata = 'http://localhost/SSDREST/odata/'

app.config(function ($locationProvider) {
  //$locationProvider.html5Mode(true);
});

// Armado del menu
app.controller('MenuCtrl', ['$scope', function ($scope) {
  $scope.items = [
    //{ titulo: 'Home', url: '#home', icono: 'flaticon-home63' },
    { titulo: 'Personas', url: 'index.html', icono: 'flaticon-users81' },
    { titulo: 'Categorias', url: 'categorias.html', icono: 'flaticon-multiple25' },
    { titulo: 'Entrenamientos', url: 'index.html', icono: 'flaticon-homework' },
    { titulo: 'Destrezas', url: 'index.html', icono: 'flaticon-americanfootball2' },
    { titulo: 'Ficha de Salud', url: 'index.html', icono: 'flaticon-stethoscope' },
    { titulo: 'Opciones', url: 'index.html', icono: 'flaticon-configuration21' },
    { titulo: 'Salir', url: 'index.html', icono: 'flaticon-door9' }
  ];
}]);
app.config(function ($mdThemingProvider) {
  // Extend the red theme with a few different colors
  var indigoMap = $mdThemingProvider.extendPalette('indigo', {
    '500': '06326a'
  });
  // Register the new color palette map with the name <code>neonRed</code>
  $mdThemingProvider.definePalette('MiIndigo', indigoMap);
  // Use that theme for the primary intentions
  $mdThemingProvider.theme('default')
    .primaryPalette('MiIndigo')
});

app.controller('AppCtrl', ['$scope', '$mdSidenav', function ($scope, $mdSidenav) {
  $scope.toggleSidenav = function (menuId) {
    $mdSidenav(menuId).toggle();
  };


}]);



app.directive('jqm', function ($timeout) {
  return {
    link: function (scope, elm, attr) {
      $timeout(function () {
        elm.trigger('create');
      });
    }
  };
});
