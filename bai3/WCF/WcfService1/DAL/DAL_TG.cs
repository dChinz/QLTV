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
        Tacgia tg = new Tacgia();

        public List<Tacgia> Loadtg()
        {
            List<Tacgia> tacgias = new List<Tacgia>();
            DataTable dt = Load("select * from Tacgia");
            foreach (DataRow dr in dt.Rows)
            {
                Tacgia tacgia = new Tacgia
                {
                    matg = Convert.ToInt32(dr["Matg"].ToString()),
                    tentg = dr["Tentg"].ToString(),
                    gioitinh = dr["Gioitinh"].ToString()
                };
                tacgias.Add(tacgia);
            }
            return tacgias;
        }

        public void Insert(Tacgia tg)
        {
            string sql = "insert into Tacgia values ('" + tg.tentg + "', '" + tg.gioitinh + "')";
            thuchien(sql);
        }

        public void Update(Tacgia tg)
        {
            string sql = "update Tacgia set Tentg = '"+tg.tentg+"', Gioitinh = '"+tg.gioitinh+"' where Matg = '"+tg.matg+"'";
            thuchien(sql);
        }

        public void Delete(Tacgia tg)
        {
            string sql = "delete from Tacgia where Matg = '" + tg.matg + "'";
            thuchien(sql);
        }
    }
}
