angular.module('myApp').config(['$routeProvider', '$locationProvider',
    function ($routeProvider, $locationProvider) {
        $routeProvider.when('/', {
            controller: 'listController',
            templateUrl: '/Product/Home'
        }).when('/product', {
            controller: 'listController',
            templateUrl: '/Product/Home'
        }).when('/product/:id', {
            controller: 'DetailsController',
            templateUrl: '/Product/Details'
        }).when('/product/bycategory/:id', {
            controller: 'listController',
            templateUrl: '/Product/Home'
        });

        $locationProvider.html5Mode(true);
    }]);