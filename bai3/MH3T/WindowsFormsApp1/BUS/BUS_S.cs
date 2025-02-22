using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_S
    {
        DAL_S dal = new DAL_S();
        public DataTable Loads()
        {
            return dal.Loads();
        }

        public void Insert(Sach s)
        {
            dal.Insert(s);
        }

        public void Update(Sach s)
        {
            dal.Update(s);
        }

        public void Delete(Sach s)
        {
            dal.Delete(s);
        }

        public DataTable data(string Tentg, string Tennx)
        {
            return dal.data(Tentg, Tennx);
        }
    }
}
