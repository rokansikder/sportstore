angular.module('myApp').factory('ProductV1', ['$q', '$http', 'API_ENDPOINT',
    function ($q, $http, API_ENDPOINT) {
        return {
            products: function(){
                return $http({ method: 'GET', url: API_ENDPOINT+'/Product' })

            },
            productsbyCat: function (id) {
              
                return $http({ method: 'GET', url: API_ENDPOINT + '/Product/bycategory/' + id })
            }
            
        }
    }])

angular.module('myApp').factory('Product', ['$resource', 'API_ENDPOINT',
function ($resource, API_ENDPOINT) {
    return $resource(API_ENDPOINT+'product/', { id: '@id' })
}]);