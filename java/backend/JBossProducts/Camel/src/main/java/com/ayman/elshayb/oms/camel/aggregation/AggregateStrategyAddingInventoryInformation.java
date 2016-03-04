package com.ayman.elshayb.oms.camel.aggregation;

import javax.xml.xpath.XPath;
import javax.xml.xpath.XPathConstants;
import javax.xml.xpath.XPathExpressionException;
import javax.xml.xpath.XPathFactory;

import org.apache.camel.Exchange;
import org.apache.camel.builder.xml.XPathBuilder;
import org.apache.camel.processor.aggregate.AggregationStrategy;
import org.apache.log4j.Logger;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class AggregateStrategyAddingInventoryInformation implements AggregationStrategy {
	Logger LOGGER = Logger.getLogger(AggregateStrategyAddingInventoryInformation.class);

	@Override
	public Exchange aggregate(Exchange order, Exchange inventory) {

		NodeList itemList= XPathBuilder.xpath("//item/id").evaluate(order, NodeList.class);
		int i=0;
		for(;i<itemList.getLength();i++){
			Node item = itemList.item(i);
			try {
				addInventory(item.getTextContent(),order, inventory);
			} catch (XPathExpressionException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			
		}	

		return order;
	}

	private void addInventory(String itemID, Exchange order,Exchange inventory) throws XPathExpressionException {
		
		Node itemNode= XPathBuilder.xpath("//item[id=$itemID]").variable("itemID", itemID).evaluate(order, Node.class);
		
		LOGGER.info("itemID = " + itemID);
		
		
		Node itemInventory= XPathBuilder.xpath("//item[id=$itemID]/amount").variable("itemID", itemID).evaluate(inventory, Node.class);
		
		LOGGER.info("itemInventory = " + itemInventory);
		
		itemInventory= itemNode.getOwnerDocument().importNode(itemInventory, true);
		itemNode.appendChild(itemInventory);
		
	}

	

}
