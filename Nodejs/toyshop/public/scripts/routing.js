/**
	This file configure the routing between pages.
	The site contains 5 pages
	home.htm: Template for other pages
	product.htm: displays the products
	shopcart.htm: displays the user shop cart .
	contactus.htm: displays information about site 	and my contact
	statistics.htm: displays Trend chart of the buying
**/
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