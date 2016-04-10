using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS3.Domain
{
    [Serializable]
    public class Expense:Entity
    {
        public string Name { get; set; }
    }
}
