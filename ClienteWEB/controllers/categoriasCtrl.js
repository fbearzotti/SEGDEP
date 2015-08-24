// Controllers 

//var app = angular.module('categoriasApp', [])
var uri = 'http://localhost/SSDREST/odata/categorias';

SSDApp.controller('categoriasCtrl', function ($scope, $http) {
  var filtros = '?$filter=idTemporada eq 4&&orderby=nombre&$select=ID,nombre,deno';
  $http.get(uri + filtros)
  .success(function (response) { $scope.categorias = response.value; });
});

