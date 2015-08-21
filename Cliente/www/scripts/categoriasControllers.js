var categoriasControllers = angular.module('categoriasControllers', [])
var uri = 'http://localhost/SSDREST/odata/categorias';

categoriasControllers.controller('categoriasCtrl', function ($scope, $http) {
  var filtros = '?$filter=idTemporada eq 4&&orderby=nombre&$select=ID,nombre,deno';
  $http.get(uri + filtros)
  .success(function (response) { $scope.categorias = response.value; });
});

categoriasControllers.controller('categoriasPersonasCtrl', function ($scope, $http) {
  var IDcategoria = getQueryVariable("idcategoria");
  var filtros = '?$select=apellido,nombre,foto,activo&$filter=activo eq \'1\' and categoriasPersonas/any(d:d/idCategoria eq 35)&$orderby=apellido ';
  $http.get(uri + filtros)
  .success(function (response) { $scope.personas = response.value; });
});


