angular.module('myApp').factory('Category', ['$http', '$resource', 'API_ENDPOINT',
    function ($http, $resource, API_ENDPOINT) {
        return $resource(API_ENDPOINT + 'category/', { id: '@id' })

    }]);