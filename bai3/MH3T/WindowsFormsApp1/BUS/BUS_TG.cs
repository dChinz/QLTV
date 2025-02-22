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
    public class BUS_TG
    {
        DAL_TG dal = new DAL_TG();

        public DataTable Loadtg()
        {
            return dal.Loadtg();
        }

        public void Insert(Tacgia tg)
        {
            dal.Insert(tg);
        }

        public void Update(Tacgia tg)
        {
            dal.Update(tg);
        }

        public void Delete(Tacgia tg)
        {
            dal.Delete(tg);
        }
    }
}
