angular.module('myApp').config(['$stateProvider', '$locationProvider', '$urlRouterProvider',
    function ($stateProvider, $locationProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise("/");

        $stateProvider.state('home.mainPage', {
            cache: false,
            url: '/',
            controller: 'listController',
            templateUrl: '/Product/Home'
        }).state('product', {
            cache: false,
            url:'/product',
            controller: 'listController',
            templateUrl: '/Product/Home'
        }).state('productbyid', {
            cache: false,
            url:'/product/:id',
            controller: 'DetailsController',
            templateUrl: '/Product/Details'
        });

        
        //$urlRouterProvider.otherWise('home.mainPage');
        $locationProvider.html5Mode(true);
    }]);