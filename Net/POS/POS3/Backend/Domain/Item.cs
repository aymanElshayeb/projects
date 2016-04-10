using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS3.Domain
{
    [Serializable()]
    public class Item : Entity
    {
 
        public string Barcode { get; set; }
        public string Name { get; set; }

        public Item( string Id, string Barcode, string Name)
        {
            this.Id = Id;
            
            this.Barcode = Barcode;
            this.Name = Name;

        }

    }
}
