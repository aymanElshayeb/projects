using POS3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS3
{
    /**
        This interface should be implemented by every Form that support
        create, update , delete operations
    **/
    public interface CUDUI<T>
    {
        void create(T entity);
        void update(T entity);
        void delete(T entity);
        


    }
}
