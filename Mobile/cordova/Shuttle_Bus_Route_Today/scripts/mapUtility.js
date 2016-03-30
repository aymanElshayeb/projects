console.log("mapUtillity.js is loaded successfully");
function placeMarker(location,map) {
		  var marker = new google.maps.Marker({
				position: location,
				animation:google.maps.Animation.BOUNCE,
				map: map
			  });
			  
		  var infowindow = new google.maps.InfoWindow({
			content:  location.lat + '</br>' + location.lng
		  });
		  
		  infowindow.open(map,marker);
		  return marker;
		  
}

function drawRoute(map,markers) {
	
	var route=new google.maps.Polyline({
					  path:markers,
					  strokeColor:"#0000FF",
					  strokeOpacity:0.8,
					  strokeWeight:2
					  });

		route.setMap(map);
	return route;
}
	

					
		
