angular.module('myApp', ['ui.router', 'ngResource']);

angular.module('myApp').value('API_ENDPOINT', 'http://localhost:1111/api/');

angular.module('myApp').run(['$state', function ($state) {
    $state.go('product');
}]);

angular.module('myApp').run(function ($rootScope, $templateCache) {
    $rootScope.$on('$viewContentLoaded', function () {
        $templateCache.removeAll();
    });
});