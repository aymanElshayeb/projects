using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS3.Domain
{
    [Serializable()]
    public class Entity
    {
        public string Id { get; set; }
        public override bool Equals(object obj)
        {
            if (!(obj is Entity))
            {
                return false;
            }

            if (this.Id == null)
            {
                throw new Exception("Empty Id");
            }
            
            return this.Id.Equals(((Entity)obj).Id);
            
        }
    }
}
