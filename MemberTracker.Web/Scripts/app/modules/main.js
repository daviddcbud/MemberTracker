var mainapp = angular.module('membertrackerapp', []).
config(function ($routeProvider)
{
    $routeProvider.when('/register', {
        templateUrl: 'Templates/register.html',
        controller: 'RegisterController'
    });
});


