angular.module('myApp').controller('listController', ['ProductV1','Category','$scope','$stateParams','$location','$state',
    function (ProductV1, Category, $scope, $stateParams, $location, $state) {
        getCategories();
      
        function getCategories() {
            Category.categories().then(function (response) {
                $scope.categories = response.data;
                
            });
        }
       
        $state.go('product.dashboard');
    }]);

angular.module('myApp').controller('DetailsController', ['Product','$stateParams','$scope',
function (Product, $stateParams, $scope) {
    $scope.productname = 'Ajaira product';
    
    $scope.product = Product.get({ id: $stateParams.id });
}]);


angular.module('myApp').controller('productListController', ['ProductV1', 'Category', '$state', '$scope', '$stateParams', '$location',
    function (ProductV1, Category,$state, $scope, $stateParams, $location) {
       
        getProducts11();
        function getProducts11() {
            var id = $stateParams.id.length == 0 ? 0 : $stateParams.id;
           
            if (id > -1) {
                    ProductV1.productsbyCat(id).then(function (response) {
                    
                    $scope.products = response.data;
                  
                });

                //$state.go('product.dashboard');
            }
        }
}]);