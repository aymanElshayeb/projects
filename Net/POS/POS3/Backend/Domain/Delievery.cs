using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS3.Domain
{
    [Serializable()]
    public class Delievery : Entity
    {
  
        public string Name { get; set; }

        public Delievery(String Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public Delievery()
        {

        }

        public override string ToString()
        {
            string customerString = "\n-----------------Delievery------------------";
            customerString = customerString + "\n Id: " + Id;            
            customerString = customerString + "\n Name: " + Name;
            customerString = customerString + "\n ------------------------------\n";
            return customerString;

        }
    }
}
