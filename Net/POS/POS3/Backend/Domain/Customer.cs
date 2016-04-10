using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS3.Domain
{
    [Serializable()]
    public class Customer: Entity
    {
        
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }


        public Customer(string Code, string Name, string Address,string Telephone)
        {
            this.Code = Code;
            this.Name = Name;
            this.Address = Address;
            this.Telephone = Telephone;
        }
        public Customer()
        {

        }
        
        public override string ToString()
        {
            string customerString = "\n-----------------Customer------------------";
            customerString = customerString + "\n Id: " + Id;
            customerString = customerString + "\n Code: " + Code;
            customerString = customerString + "\n Name: " + Name;
            customerString = customerString + "\n Address: " + Address;
            customerString = customerString + "\n Telephone: " + Telephone;
            customerString = customerString + "\n ------------------------------\n";
            return customerString;

        }

    }
}
