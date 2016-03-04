package com.ayman.www;

@ManagedBean(name = "helloWorld", eager = true)
public class HelloWorld {
   public HelloWorld() {
      System.out.println("HelloWorld started!");
   }
   public String getMessage() {
      return "Hello World!";
   }
}