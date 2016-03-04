var app = angular.module('loginApp', []);
app.controller('formControl', function($scope, userService) {
	
	$scope.check= function(){
	
						if(userService.check(this.user)== true){
							window.location="success.html";
						}else if(userService.check(this.user)== true){
							this.invalid=true;
						}else{
							return;
						}
						
					}
	

});

app.service('userService',  function(){
	
			this.check=function(user){
							
									if((user.name=="ayman") && (user.password=="ayman")){
										return true;
									}else{
										return false;
									}
			}
});

