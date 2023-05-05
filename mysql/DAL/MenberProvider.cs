using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql.DAL
{
    public class MenberProvider :ProviderBase, IPorvider<Member> 
    {
        public int Delete(Member enity)
        {
        db.Entry(enity).State=System.Data.Entity.EntityState.Deleted;
           return db.SaveChanges(); 
        }

        public List<Member> GetAll()
        {
            return db.Member.ToList();
        }

        public int Insert(Member enity)
        {
            db.Entry(enity).State=System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }

        public int Update(Member enity)
        {
            db.Entry(enity).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
