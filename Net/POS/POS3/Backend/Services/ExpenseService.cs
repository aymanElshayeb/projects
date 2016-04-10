using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS3.Domain;

namespace POS3.Services
{
    class ExpenseService : BasisService<Expense>
    {
        public override Expense getEmpty()
        {
            return new Expense { Id = "", Name = "" };
        }

        }

        
    
}
