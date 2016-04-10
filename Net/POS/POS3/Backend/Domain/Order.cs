using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  POS3.Domain
{
    [Serializable()]
    public class Order : Entity
    {
        
        public string Number { get; set; }
        public List<OrderItem> OrderItemList { get; set; }
        public double Total { get {
                OrderItem[] orderItemArray = OrderItemList.ToArray<OrderItem>();
                double sum = 0;
                for (int i = 0; i < orderItemArray.Length; i++)
                {
                    sum = sum + orderItemArray[i].TotalPrice;
                }
                return sum;
            } }
        public double Paid { get; set;}
        public double Remaining { get { return (Paid- Total); } }
        public Customer Customer{ get; set; }
         public Delievery Delievery{ get; set; }

    public Order(string Id, string Number, List<OrderItem> OrderItemList, Customer Customer , Delievery Delievery)
        {
            this.Id = Id;
            this.Number = Number;
            this.OrderItemList = OrderItemList;
            this.Customer = Customer;
            this.Delievery = Delievery;
        }

    public Order()
        {

        }

        public override string ToString()
        {
            string customerString = "\n-----------------Order------------------";
            customerString = customerString + "\n Id: " + Id;
            customerString = customerString + "\n Number: " + Number;
            customerString = customerString + "\n Total: " + Total;
            customerString = customerString + "\n Paid: " + Paid;
            customerString = customerString + "\n Remaining: " + Remaining;
            customerString = customerString + "\n Customer: " + Customer;
            customerString = customerString + "\n Delievery: " + Delievery;
            customerString = customerString + "\n -----------OrderItemList-------------------\n";
            OrderItem[] orderItemArray= OrderItemList.ToArray<OrderItem>();
            for (int i=0;i<orderItemArray.Length;i++ )
            {
                customerString = customerString + "\n OrderItem : " + orderItemArray[i];
            }
           
            customerString = customerString + "\n ------------------------------\n";
            return customerString;

        }


    }
}

