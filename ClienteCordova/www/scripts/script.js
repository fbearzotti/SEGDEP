//create a module SSDApp
var SSDApp = angular.module('SSDApp', ['ngRoute', 'categoriasControllers']);

$(document).ready(function () {
  
});

  //Now Configure  our  routing
  SSDApp.config(function ($routeProvider, $locationProvider) {
    /** set route for the index page and it load uirouter.html
      *in ng-view and activate RouteCtrl
      **/
    //.when('/', {
    //  controller: 'RouteCtrl',
    //  templateUrl: 'uirouter.html'
    //})
    //// if not match with any route config then send to home page
    //.otherwise({
    //  redirectTo: '/home'
    //});
  });




