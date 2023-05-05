using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql.DAL
{
   public class AirTransportProvider:ProviderBase,IPorvider<AirTransport>
    {
        public int Delete(AirTransport enity)
        {
            db.Entry(enity).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }

        public List<AirTransport> GetAll()
        {
            return db.AirTransport.ToList();
        }

        public int Insert(AirTransport enity)
        {
            db.Entry(enity).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }

        public int Update(AirTransport enity)
        {
            db.Entry(enity).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}

