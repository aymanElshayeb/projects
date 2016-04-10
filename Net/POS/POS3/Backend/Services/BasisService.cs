using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS3.Domain;
namespace POS3.Services
{
    public abstract class BasisService<T> where T:Entity
    {
        public abstract T getEmpty();
        public int count;

        public virtual List<T> findAll()
        {
            List<T> list = new List<T>();
            return list;

        }

        public virtual T findOne(T entity)
        {

            return entity;
        }

        public virtual  bool add(T entity)
        {

            entity.Id = "12345"+count;
            count++;
            return true;

            //throw new NotImplementedException();
        }

        public virtual  void update(T entity)
        {
            //throw new NotImplementedException();
        }

        public virtual void delete(T entity)
        {
            //throw new NotImplementedException();
        }
    }
}
