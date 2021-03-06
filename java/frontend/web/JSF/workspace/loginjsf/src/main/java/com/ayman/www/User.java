package com.ayman.www;
import javax.faces.application.FacesMessage;
import javax.faces.bean.ManagedBean;
import javax.faces.context.FacesContext;
@ManagedBean(name = "user", eager = true)
public class User {
	private String name;
	private String password;

	
   public boolean validate() {	   
	   return ("ayman".equalsIgnoreCase(name)) &&("ayman".equalsIgnoreCase(password));		   	  
   }

public String getName() {
	return name;
}

public void setName(String name) {
	this.name = name;
}

public String getPassword() {
	return password;
}

public void setPassword(String password) {
	this.password = password;
}

	public String  login(){
		
		if(this.validate()){
			return "success";
			
		}else{
			FacesContext.getCurrentInstance().addMessage(
                    "username",
                    new FacesMessage(FacesMessage.SEVERITY_ERROR,
                            "Incorrect Username and Passowrd",
                            "Please enter correct username and Password"));
			return "home";
		}
		
		//validate , if yes direct to success otherwise direct to same page with error
		//redirect
	}

	
	
   
}