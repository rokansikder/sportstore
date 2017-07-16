angular.module('myApp').config(['$stateProvider', '$locationProvider',
    function ($stateProvider, $locationProvider) {
        $stateProvider.state('product.dashboard', {
            url: '/category/:id',
            controller: 'productListController',
            templateUrl: '/product/list'
        }).state('product.category', {
            url: 'product/category',
            controller: 'listController',
            templateUrl: '/Product/Home'
        }).state('product.dashboard1', {
            url: '/category/:id',
            controller: 'productListController',
            templateUrl: '/product/list'
        });

        //$locationProvider.html5Mode(true);
    }]);