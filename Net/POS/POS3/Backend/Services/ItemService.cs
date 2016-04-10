using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS3.Domain;

namespace POS3.Services
{
    class ItemService:BasisService<Item>
    {
        public override Item getEmpty()
        {
            return new Item("", "", "");
        }

        }

        
    
}
