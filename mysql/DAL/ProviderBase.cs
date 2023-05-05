using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql.DAL
{
    public abstract class ProviderBase
    {
        protected OrderDBEntities db = null;
        public ProviderBase()
        { 
        this.db = new OrderDBEntities();
        
        }
    }
}
