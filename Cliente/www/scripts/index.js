// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkID=397704
// To debug code on page load in Ripple or on Android devices/emulators: launch your app, set breakpoints, 
// and then run "window.location.reload()" in the JavaScript Console.
(function () {
  "use strict";



  $(document).ready(function () {
    inicializoMenu();
  });

  document.addEventListener('deviceready', onDeviceReady.bind(this), false)

  function onDeviceReady() {
    // Handle the Cordova pause and resume events
    document.addEventListener('pause', onPause.bind(this), false);
    document.addEventListener('resume', onResume.bind(this), false);

    // TODO: Cordova has been loaded. Perform any initialization that requires Cordova here.
    inicializoMenu();
  };

  function onPause() {
    // TODO: This application has been suspended. Save application state here.
  };

  function onResume() {
    // TODO: This application has been reactivated. Restore application state here.
  };

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
        href: 'main.html?categorias',
        text: 'Listado Categorias'
      },
      {
        href: '#entrenamientos',
        text: 'Entrenamientos',
        children: [{
          href: 'categorias.html',
          text: 'Listado Entrenamientos',
        }, {
          href: 'categorias.html',
          text: 'Toma de Presentismo'
        }]
      },

      {
        href: 'login.html',
        text: 'Ingreso al sistema'
      }]
    });

  }

})();