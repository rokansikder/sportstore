angular.module('myApp').controller('listController', ['ProductV1','Category','$scope','$routeParams','$location',
    function (ProductV1, Category, $scope, $routeParams, $location) {
        getCategories();
        getProducts();
        function getCategories() {
            Category.categories().then(function (response) {
                $scope.categories = response.data;
            });
        }
       
        function getProducts() {
            var loc = $location.path();
           
            if (loc.includes('/product/bycategory/')) {
                
                ProductV1.productsbyCat($routeParams.id).then(function (response) {
                    $scope.products = response.data;
                });
            }
            else {
                
            ProductV1.products().then(function (response) {
                $scope.products = response.data;
            });
            }
        }


        //$scope.products = Product.query();
    }]);

angular.module('myApp').controller('DetailsController', ['Product','$routeParams','$scope',
function (Product, $routeParams, $scope) {
    $scope.productname = 'Ajaira product';
    
    $scope.product = Product.get({ id: $routeParams.id });
    }]);