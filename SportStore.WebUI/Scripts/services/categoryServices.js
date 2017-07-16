angular.module('myApp').factory('Category', ['$http', '$state', 'API_ENDPOINT',
    function ($http, $state, API_ENDPOINT) {
        return {
            categories: function(){
                return $http({method:'GET', url:API_ENDPOINT+'category/'});
            }
        }
    }])