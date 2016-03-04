package com.ayman.elshayb.oms.camel.routes;

import org.apache.camel.builder.RouteBuilder;

import com.ayman.elshayb.oms.camel.aggregation.AggregateStrategyAddingCustomerData;
import com.ayman.elshayb.oms.camel.aggregation.AggregateStrategyAddingInventoryInformation;

/**
 * The target of this project is to practice applying EIP patterns by Apache Camel Fuse.We choose to implement small Order management system (OMS) integration project. 
 * The project will be implemented in  many releases. Each release adds more feature to OMS project. By this way we gradually get deep in the Apache Camel features.
 * The target of first release of this project is to get familiar of Apache camel .This class represents the route of the first release .  
    
 */
public class OMSMainRouteBulider extends RouteBuilder {

	/**
	 * Main routes  configuration. There are three steps in first release of this application.
	 * First step is to get the Order then apply the enrich Pattern to add customer data.
	 * Second step is to enrich order by Inventory 
	 */
	public void configure() {

		// Adding Customer Information
		//TODO:There is a bug here. when dealing with many orders a dead lock is happend
		from("file:src/data/OrdersSource?fileName=order1.xml&noop=true")
				.log("Starting process orders")
				.pollEnrich("file:src/data/CustomerData?fileName=customers.xml&noop=true",
						new AggregateStrategyAddingCustomerData())
				.log("${in.body}").to("direct:check Inventory");

		// Add Inventory
		from("direct:check Inventory").log("Starting Adding Inventory")
				.pollEnrich("file:src/data/Inventory?fileName=inventory.xml&noop=true",
						new AggregateStrategyAddingInventoryInformation())
				.log("${in.body}").to("direct:check order");

		// Check the inventory . if it is ok then send to billing and save in
		// OrderStorage folder else send to invalid folder
		from("direct:check order").choice().when(xpath("//item[quantity>=amount]")).to("file:src/data/Billing")
				.to("file:src/data/OrderStorage").otherwise().to("file:src/data/InvalidOrders");

	}

}
