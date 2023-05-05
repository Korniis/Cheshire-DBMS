using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql.DAL
{
    public  class AirTransportDetailsProvider:ProviderBase,IPorvider<AirTransportDetails>
    {
        public int Delete(AirTransportDetails enity)
        {
            db.Entry(enity).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }

        public List<AirTransportDetails> GetAll()
        {
            return db.AirTransportDetails.ToList();
        }

        public int Insert(AirTransportDetails enity)
        {
            db.Entry(enity).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }

        public int Update(AirTransportDetails enity)
        {
            db.Entry(enity).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
