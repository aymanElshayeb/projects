using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS3.Domain;
using POS3.Repository;
namespace POS3.Services
{
    class OrderService:BasisService<Order>
    {
        public override Order getEmpty()
        {
            Customer Customer = new Customer("","","","");
            Delievery Delievery = new Delievery("","");
            List<OrderItem> OrderItemList = new List<OrderItem>();
            Order Order = new Order("","NewOrder", OrderItemList, Customer, Delievery);
            return Order;
        }

        public OrderItem getOrderItem(string code)
        {
            OrderItem OrderItem = new OrderItem(code, "Cheese", 1, 5);
            return OrderItem;
        }

        public override List<Order> findAll()
        {
            List<Order> orderList = new List<Order>();
            for(int i = 0; i < 10; i++)
            {
                Order order= getEmpty();
                orderList.Add(order);
            }
            orderList[0].Number = "Existing Order";
            orderList[0].OrderItemList.Add(this.getOrderItem("A1111"));
            return orderList;
        }

        
    }
}
