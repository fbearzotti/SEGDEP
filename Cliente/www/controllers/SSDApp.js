var app = angular.module('SSDApp', [])
var uri = 'http://localhost/SSDREST/odata/categorias';

app.controller('categoriasCtrl', function ($scope, $http) {
  var filtros = '?$filter=idTemporada eq 4&&orderby=nombre&$select=ID,nombre,deno';
  $http.get(uri + filtros)
  .success(function (response) { $scope.categorias = response.value; });
});

app.controller('categoriasPersonasCtrl', function ($scope, $http) {
  var IDcategoria = getQueryVariable("idcategoria");
  alert(IDcategoria);
  var filtros = '?$select=apellido,nombre,foto,activo&$filter=activo eq \'1\' and categoriasPersonas/any(d:d/idCategoria eq 35)&$orderby=apellido ';
  $http.get(uri + filtros)
  .success(function (response) { $scope.personas = response.value; });
});

function getQueryVariable(variable) {
  var query = window.location.search.substring(1);
  var vars = query.split("&");
  for (var i = 0; i < vars.length; i++) {
    var pair = vars[i].split("=");
    if (pair[0] == variable) { return pair[1]; }
  }
  return (false);
}
