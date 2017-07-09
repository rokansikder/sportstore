angular.module('myApp').factory('Category', ['$http', '$route', 'API_ENDPOINT',
    function ($http, $route, API_ENDPOINT) {
        return {
            categories: function(){
                return $http({method:'GET', url:API_ENDPOINT+'category/'});
            }
        }
    }])