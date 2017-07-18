angular.module('myApp').controller('categoryListController', ['Category', '$scope',
    function (Category, $scope) {
        $scope.categories = Category.query();
        $scope.output = 'onk kisu paisi re vai';
    }]);