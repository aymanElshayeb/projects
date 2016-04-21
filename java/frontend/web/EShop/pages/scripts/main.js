var mainApp = angular.module("mainApp");
mainApp.controller('mainController', function($scope) {
	
	$scope.products=[
	{
	id:1,
	name: "Car toy",
	type: "baby", 
	image: "images/toy1.jpg",
	price:10
	},
	{
	id:2,
	name: "Casher toy",
	type: "baby",
	image: "images/toy2.jpg",	
	price:20
	},
	{
	id:3,
	name: "Car toy",
	type: "baby", 
	image: "images/toy3.jpg",
	price:30
	},
	{
	id:4,
	name: "Tortoise toy",
	type: "baby", 
	image: "images/toy4.jpg",
	price:40
	},
	{
	id:5,
	name: "Tortoise toy",
	type: "baby", 
	image: "images/toy5.jpg",
	price:40
	},
	{
	id:6,
	name: "Tortoise toy",
	type: "baby", 
	image: "images/toy6.jpg",
	price:40
	},
	{
	id:7,
	name: "Tortoise toy",
	type: "baby", 
	image: "images/toy7.jpg",
	price:40
	},
	{
	id:8,
	name: "Tortoise toy",
	type: "baby", 
	image: "images/toy8.jpg",
	price:40
	},
	{
	id:9,
	name: "Tortoise toy",
	type: "baby", 
	image: "images/toy9.jpg",
	price:40
	},
	{
	id:10,
	name: "Tortoise toy",
	type: "baby", 
	image: "images/toy10.jpg",
	price:40
	},
	{
	id:11,
	name: "Tortoise toy",
	type: "baby", 
	image: "images/toy11.jpg",
	price:40
	}
];
$scope.currentUser={
					id:1,
					name:"Ayman",
					mail:"aymanbasic@yahoo.com"
					};



			
});
mainApp.service('cartService', function(){
	this.addToCart = function(product,currentUser) {
		
				if(sessionStorage["cart"]==null){
					cart= 	{
							cartItems:[	],
							user:currentUser
						};	
				}else{
					cart=JSON.parse(sessionStorage["cart"]);
				}
				cart.cartItems.push({product:product, amount:1});
				sessionStorage ["cart"]=JSON.stringify(cart);
				console.log(cart);
			};
	this.getCart=function() {
		
				if(sessionStorage["cart"]==null){
					cart= 	{
							cartItems:[	],
							user:currentUser
						};	
				}else{
					cart=JSON.parse(sessionStorage["cart"]);
				}
				cart.Total=cart.cartItems.reduce(function(previousValue, currentValue, currentIndex, array){
					return previousValue+(currentValue.product.price * currentValue.amount); 
				},0);
				return cart;
			};
	
			
});
mainApp.controller('productsController', function($scope,cartService) {
	
	
	
	$scope.addToCart= function(prodctId){
		
				var product= $scope.products.filter(function(obj){
					return (obj.id==prodctId);
				}
				
				);
				if(product==null|| product.length>0){
					cartService.addToCart(product[0],$scope.currentUser);		
				}
			
			 
			};
			
	
	
});
mainApp.controller('shopcartController', function($scope,cartService) {
	$scope.cart=cartService.getCart();
});
mainApp.controller('contactusController', function($scope) {

	
});
mainApp.controller('statisticsController', function($scope) {

	
});