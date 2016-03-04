package com.ayman.elshayb.oms.camel.aggregation;

import org.apache.camel.Exchange;
import org.apache.camel.builder.xml.XPathBuilder;
import org.apache.camel.processor.aggregate.AggregationStrategy;
import org.apache.log4j.Logger;
import org.w3c.dom.Node;

public class AggregateStrategyAddingCustomerData implements AggregationStrategy {
	Logger LOGGER = Logger.getLogger(AggregateStrategyAddingCustomerData.class);

	@Override
	public Exchange aggregate(Exchange order, Exchange customer) {

		if (customer == null) {
			LOGGER.info("customer is Null");
		}
		if (order == null) {
			LOGGER.info("order is Null");
		}

		// Get customer ID
		String customerID = XPathBuilder.xpath("order/customer/id/text()").evaluate(order, String.class);
		LOGGER.info("customerID =" + customerID);

		// Get customer data
		Node newCustomerNode = XPathBuilder.xpath("customers/customer[id=$customerID]")
				.variable("customerID", customerID).evaluate(customer, Node.class);

		LOGGER.info("newCustomerNode =" + newCustomerNode);

		// Insert new customer data
		try {

			Node oldCustomerNode = XPathBuilder.xpath("order/customer").evaluate(order, Node.class);
			LOGGER.info("oldCustomerNode =" + oldCustomerNode);
			
			//Import Nodes
			newCustomerNode=oldCustomerNode.getOwnerDocument().importNode(newCustomerNode, true);
			oldCustomerNode.getParentNode().replaceChild(newCustomerNode,oldCustomerNode);

			
			
			LOGGER.info("Parent =" + oldCustomerNode.getParentNode());
			 order.getIn().setBody(newCustomerNode.getOwnerDocument());
			 return order;
		} catch (Exception e) {
			e.printStackTrace();

			LOGGER.error(e.getMessage());

		}
	

		return order;
	}

}
