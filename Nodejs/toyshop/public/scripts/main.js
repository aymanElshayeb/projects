/**
	This is the main javascripts class for the Toy shop application/

	It contains controller for each page and contains  three services
	Controllers are
	mainController: contains the global variables and functiosn of the application
	productsController:  contains variable and functions of products page
	shopcartController:  contains variable and functions of shopcart page
	contactusController: contains variable and functions of contactus page
	statisticsController: contains variable and functions of statistics page
	
	Services are 
	userService: to get the current user . This version assumes predefine user called "ayman". 
	cartService: this service contains methods to get cart , delete it and method to add item to cart
	statisticsService: this service contains  method to get statistic from backend
	
**/
var mainApp = angular.module("mainApp");
//get the server URL from configuration
var serverURL= config.serverURL;
mainApp.controller('mainController', function($scope,$http,userService) {
//Get current user	
$scope.currentUser=userService.getCurrentUser();

//Get products from backend
 $http.get(serverURL+"/product")
    .then(function(response) {
	
       $scope.products = response.data;		
	
    },function(response) {

	console.log(JSON.stringify(response));	
    
	
    });					
//Default filter critria for products  
$scope.search={type: "baby"};	
//set the filter critria for products  
$scope.filter= function(typ){
	
	$scope.search={type: typ};	
}
			
});
mainApp.service('userService', function(){
	//Default user 
	this.getCurrentUser = function (){
							//Dummy user
							var currentUser=	{
											id:1,
											name:"Ayman",
											mail:"aymanbasic@yahoo.com"
											};
								return currentUser;
						}; 
});
mainApp.service('cartService', function($http,userService){
	//Get current user
	var currentUser= userService.getCurrentUser();
	//add product to cart
	this.addToCart = function(product) {
				var cart=null;
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
			
			};
		//delete cart from session
	this.deleteCart=function deleteCart() {

						sessionStorage.removeItem("cart");
						
						
	
				};
	//Get user cart
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
	
	//submit cart to backend
	this.submitCart=function() {
		
				$http(
				{
				  method: 'PUT',
				  url: serverURL+"/cart",
				  headers: {'Content-Type': 'application/json'},
				  
				  data: this.getCart(currentUser)

				}).then(function(response) {

							alert("Order has been submited");						
						},function(response) {
							alert("Error has been occured");
							console.log(response);
						
						});	
			};
	
			
});
mainApp.service('statisticsService', function($http){
	//Get trend chart points from backend
	var getStatistics=function() {
										return $http({ 
												method: 'GET',
												  url: serverURL+"/statistics",
											})
										.then(function(response) {
									
										
										
										return response.data;
									
									},function(response) {
										
										console.log(JSON.stringify(response));	
										return;
									
									});
							}
			return {getStatistics:getStatistics}
			
});

mainApp.controller('productsController', function($scope,cartService) {
	//Add product to cart	
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
	//Get current user cart
	$scope.cart=cartService.getCart();
	//submit cart
	$scope.submitCart= function(){
				
				//submit cart
				cartService.submitCart();				
				//delete cart from session
				cartService.deleteCart();
				//update the UI
				$scope.cart=cartService.getCart();;
			 
			};	
});
mainApp.controller('contactusController', function($scope) {
  
  //Cairo location
  var mapProp = {
					center:new google.maps.LatLng(30.050799652359263,30.986251831054688),
					zoom:5

				};
  //Initiate map
  plannedRouteMap=new google.maps.Map(document.getElementById("googleMap"),mapProp);
	
});
mainApp.controller('statisticsController', function($scope,statisticsService) {
	
	//X scale 
	var xscale=24;
	//Y scale
	var yscale=1.5;
	//margin of the graph 
	var d=20;
	//Y height
	var height=400-d;
	//X height
	var width=400-d;
	//X axis points
	var xaxisPoint=[{"x":0,"y":0},{"x":14,"y":0}];
	//Y axis points
	var yaxisPoint=[{"x":0,"y":0},{"x":0,"y":220}];
	var points=[];
	
	//	scale the point  x by xscale and y by yscale 
	function scale(point){
		point.x =point.x *xscale;
		point.y= point.y *yscale ;
	};
	//shift the axes by d
	function shift(point){
		point.x =point.x +d;
		point.y= height-point.y;
	};
	//convert the points to string
	function convertToString(p,c){
		if(p==""){
		return p=p+ c.x+" ,"+c.y;	
		}else{
			return p=p+" ,"+ c.x+" ,"+c.y;
		}
	};
	//Transform the point from normal X,Y axes to axes that can be displayed by SVG tag
	function transform(pointArray){
		//scale points
		pointArray.forEach(function(point){
			return scale(point);
		});
		//shift points from (0,0) origin to (100,300)
		pointArray.forEach(function(point){
			return shift(point);
		});
		//converts the list to string
		return pointArray.reduce(function(p,c){
			return convertToString(p,c);
		},"");	
	};
	//Get points from backend
	statisticsService.getStatistics().then(function(data){				
		$scope.linePoints =transform(data);
	});
   
   //Transform x axis
	$scope.xaxixPoints=transform(xaxisPoint);			
	//Transform y axis
	$scope.yaxixPoints=transform(yaxisPoint);
	
	//point to display the Name of X axis
	$scope.xXlable=xaxisPoint[1].x;
	$scope.yXlable=xaxisPoint[1].y;
	
	//point to display the Name of Y axis
	$scope.xYlable=yaxisPoint[1].x;
	$scope.yYlable=yaxisPoint[1].y;

	
});