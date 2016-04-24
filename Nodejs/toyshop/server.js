/**
This file represents the backend of Toy shop application.
It contains Three RestFull services 
- service to get products list
- Service to get statistics of the site
- service to submit the shop cart.

The backend just prints the submitted order and return a predefine  products stored in memory

**/
//using express module to build restful service
var express = require('express');
var app = express();
//using json middleware to parse the request and response
var bodyParser = require('body-parser');
var jsonParser = bodyParser.json();
//public folder contains images ,css javascripts and pages
app.use(express.static('public'));
app.use(jsonParser);

//return list of products
app.get('/product', function (req, res) {
	var products=[
	{
	id:1,
	name: "Car toy",
	type: "child", 
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
	type: "child", 
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
	type: "child", 
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

console.log("Get is called ");
console.log("List of  products \n %s,",JSON.stringify(products));

res.send(products);
});

//return statistics to draw Trend chart
app.get('/statistics', function (req, res) {

	var points=[{"x":1,"y":30},{"x":2,"y":40},{"x":3, "y":40},{"x":4,"y":60}, {"x":5,"y":30},{"x":6,"y":10}, {"x":7,"y":80},
					{"x":8,"y":90}, {"x":9,"y":100}, {"x":10,"y":140}, {"x":11,"y":140}, {"x":12,"y":160}];
	console.log("statistics is called ");
	console.log("list of statistics points \n %s,",JSON.stringify(points));
	res.send(points);
});
app.put('/cart', jsonParser,function (req, res) {
	
//Here we just print the cart that was submitted
console.log("cart post is called ");
console.log("cart  is \n  "+JSON.stringify(req.body)); 
res.send("ok");

});

//intiate server at port 8080
var server = app.listen(8080, function () {
var host = server.address().address
var port = server.address().port
console.log("Toy shop application is listening at http://%s:%s", host, port)
})