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
    public class BUS_NXB
    {
        DAL_NXB dal = new DAL_NXB();

        public DataTable Loadnxb()
        {
            return dal.Loadnxb();
        }

        public void Insert(Nhaxuatban nxb)
        {
            dal.Insert(nxb);
        }

        public void Update(Nhaxuatban nxb)
        {
            dal.Update(nxb);
        }

        public void Delete(Nhaxuatban nxb)
        {
            dal.Delete(nxb);
        }
    }
}
