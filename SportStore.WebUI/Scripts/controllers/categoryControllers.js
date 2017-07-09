angular.module('myApp').controller('CatListController', ['Product', '$scope',
    function (Product, $scope) {
        $scope.products = Product.query();
        $scope.output = 'onk kisu paisi re vai';
    }]);