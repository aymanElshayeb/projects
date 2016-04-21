var mainApp = angular.module("mainApp", ['ngRoute']);
mainApp.config(['$routeProvider',
				function($routeProvider) {
									$routeProvider.
													when('/products', {
													templateUrl: 'products.htm',
													controller: 'productsController'
													}).
													when('/shopcart', {
													templateUrl: 'shopcart.htm',
													controller: 'shopcartController'
													}).
													when('/contactus', {
													templateUrl: 'contactus.htm',
													controller: 'contactusController'
													}).
													when('/statistics', {
													templateUrl: 'statistics.htm',
													controller: 'statisticsController'
													}).
													otherwise({
													redirectTo: '/products'
													});
					}
				]
		);