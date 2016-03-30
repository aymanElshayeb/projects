var plannedRouteMap=null;
var currentRouteMap=null;
var pickPointMap=null;
var employslocation={};
var busPoints=[];
var busPath=null;
( function()
{
			console.log("main.js is loaded successfully");
			function initialize() {
				  var mapProp = {
									center:new google.maps.LatLng(30.050799652359263,30.986251831054688),
									zoom:8,
									mapTypeId:google.maps.MapTypeId.ROADMAP
								};
				  plannedRouteMap=new google.maps.Map(document.getElementById("plannedRoute"),mapProp);
				  currentRouteMap=new google.maps.Map(document.getElementById("currentRoute"),mapProp);
				  pickPointMap=new google.maps.Map(document.getElementById("pickPointMap"),mapProp);
				  google.maps.event.addListener(pickPointMap, 'click', function(event) {
					  var location = {lat: event.latLng.lat(), lng: event.latLng.lng()};
						placeMarker(location,pickPointMap);
						});

			}
			google.maps.event.addDomListener(window, 'load', initialize);
}
)();

function insertEmployeeLocation(){
	var latitude= document.getElementById("employeeLatitude").value;
	var langitude= document.getElementById("employeelangitude").value;
	var employeeID= document.getElementById("employeeID").value;
		if(isNaN(Number(latitude)) ||isNaN(Number(langitude))){
		alert("Either latitude or langitude is not a number");
		return ;
	}
	if ((employeeID==null) ||(employeeID=="")){
		alert("employeeID is empty");
		return ;	
	}
	 var location = {lat: Number(latitude), lng: Number(langitude)};	 	
	 if(employslocation[employeeID]==null){
	 employslocation[employeeID]=placeMarker(location,plannedRouteMap);	 
	 }
}

function removeEmployeeLocation(){
	var latitude= document.getElementById("employeeLatitude").value;
	var langitude= document.getElementById("employeelangitude").value;
	var employeeID= document.getElementById("employeeID").value;
	if(isNaN(Number(latitude)) ||isNaN(Number(langitude))){
		alert("Either latitude or langitude is not a number");
		return ;
	}
	if ((employeeID==null) ||(employeeID=="")){
		alert("employeeID is empty");
		return ;	
	}
	var markerKey=employeeID;
	if(employslocation[markerKey]!=null){
		employslocation[markerKey].setMap(null);	 
		delete employslocation[markerKey];		
	}
}

function insertRoute(){
	var latitude= document.getElementById("busLatitude").value;
	var langitude= document.getElementById("busLangitude").value;
	if(isNaN(Number(latitude)) ||isNaN(Number(langitude))){
		alert("Either latitude or langitude is not a number");
		return ;
	}
	var location = {lat: Number(latitude), lng: Number(langitude)};
	if(busPath!=null){
		busPath.setMap(null);
	}	
    placeMarker(location,currentRouteMap);
	var marker=new google.maps.LatLng(Number(latitude),Number(langitude));
	busPoints.push(marker);		
	busPath=drawRoute(currentRouteMap,busPoints);
}