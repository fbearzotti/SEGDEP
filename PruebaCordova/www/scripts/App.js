$.mobile.linkBindingEnabled = false;
$.mobile.hashListeningEnabled = false;

window.loggedIn = false;
var SSDApp = angular.module("SSDApp", ['categoriasControllers']).
controller(
	"mainController",
	[
		"$scope",
		function ($scope) {
		  $scope.$on("$includeContentLoaded", function () {
		    $("#mainDiv").trigger("create");
		  });

		  $scope.getTemplate = function () {
		    if (!window.loggedIn)
		      return "partials/login.html";
		    else
		      return "partials/main.html";
		  }
		}
	]
).controller(
	"loginController",
	[
		"$scope",
		function ($scope) {

		  $scope.userName = "";
		  $scope.password = "";

		  $scope.onSubmit = function () {
		    if ($scope.userName !== "admin" || $scope.password !== "admin") {
		      alert("Usuario o clave inválidos");
		      return;
		    }
		    window.loggedIn = true;
		    return;
		  }

		  $scope.onReset = function () {
		    $scope.userName = "";
		    $scope.password = "";
		  }
		}
	]
).controller(
	"mainPageController",
	[
		"$scope",
		function ($scope) {

		  $scope.logout = function () {
		    window.loggedIn = false;
		  }
		}
	]
)
;

SSDApp.directive('jqm', function ($timeout) {
  return {
    link: function (scope, elm, attr) {
      $timeout(function () {
        elm.trigger('create');
      });
    }
  };
});