( function()
{
			console.log("pickpoint.js is loaded successfully");
			function initialize() {
				  var mapProp = {
									center:new google.maps.LatLng(30.050799652359263,30.986251831054688),
									zoom:8,
									mapTypeId:google.maps.MapTypeId.ROADMAP
								};
				  var pickPointMap=new google.maps.Map(document.getElementById("pickPointMap"),mapProp);
				  google.maps.event.addListener(pickPointMap, 'click', function(event) {
						placeMarker(event.latLng,pickPointMap);
						});


			}
			google.maps.event.addDomListener(window, 'load', initialize);
}			
)();