using System;

namespace POS3.Domain
{
    [Serializable()]
    public class OrderItem : Entity
    {

        
        public string Code;
        public string Name { get; set; }
        public int quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get { return (this.quantity * this.UnitPrice); } }

        public OrderItem(string code, string ProdcutName, int quanity, double unitPrice)
        {
            this.Code = code;
            this.Name = ProdcutName;
            this.quantity = quanity;
            this.UnitPrice = unitPrice;
            
            

        }

        public override string ToString()
        {
            string customerString = "\n-----------------OrderItem------------------";
            customerString = customerString + "\n Id: " + Id;
            customerString = customerString + "\n Code: " + Code;
            customerString = customerString + "\n Name: " + Name;
            customerString = customerString + "\n quantity: " + quantity;
            customerString = customerString + "\n UnitPrice: " + UnitPrice;
            customerString = customerString + "\n TotalPrice: " + TotalPrice;
            customerString = customerString + "\n ------------------------------\n";
            return customerString;

        }
    }
}