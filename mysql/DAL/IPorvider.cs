using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql.DAL
{
    public interface  IPorvider<T> where T : class
    {
        int Insert(T enity);
        int Update(T enity);
        int Delete(T enity);
        List<T> GetAll();
    }
}
