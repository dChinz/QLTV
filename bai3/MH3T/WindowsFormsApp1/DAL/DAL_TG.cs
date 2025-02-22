using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TG : ketnoi
    {
        public DataTable Loadtg()
        {
            return Load("select * from Tacgia");
        }

        public void Insert(Tacgia tg)
        {
            string sql = "insert into Tacgia values ('" + tg.tentg + "', '" + tg.gioitinh + "')";
            thuchien(sql);
        }

        public void Update(Tacgia tg)
        {
            string sql = "update Tacgia set Tentg = '" + tg.tentg + "', Gioitinh = '" + tg.gioitinh + "' where Matg = '" + tg.matg + "'";
            thuchien(sql);
        }

        public void Delete(Tacgia tg)
        {
            string sql = "delete from Tacgia where Matg = '" + tg.matg + "'";
            thuchien(sql);
        }
    }
}
