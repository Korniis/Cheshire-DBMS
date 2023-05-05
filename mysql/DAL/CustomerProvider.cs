using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql.DAL
{
   public  class CustomerProvider:ProviderBase,IPorvider<Customer>
    {
        public int Delete(Customer enity)
        {
            db.Entry(enity).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return db.Customer.ToList();
        }

        public int Insert(Customer enity)
        {
            db.Entry(enity).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }

        public int Update(Customer enity)
        {
            db.Entry(enity).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
