using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NXB : ketnoi
    {
        Nhaxuatban nxb = new Nhaxuatban();

        public List<Nhaxuatban> Loadnxb()
        {
            List<Nhaxuatban> nhaxuatbans = new List<Nhaxuatban>();
            DataTable dt = Load("select * from Nhaxuatban");
            foreach (DataRow dr in dt.Rows)
            {
                Nhaxuatban nhaxuatban = new Nhaxuatban
                {
                    manxb = Convert.ToInt32(dr["Manxb"].ToString()),
                    tennxb = dr["Tennxb"].ToString(),
                    dienthoai = dr["Dienthoai"].ToString()
                };
                nhaxuatbans.Add(nhaxuatban);
            }
            return nhaxuatbans;
        }

        public void Insert(Nhaxuatban nxb)
        {
            string sql = "insert into Nhaxuatban values ('"+nxb.tennxb+"', '"+nxb.dienthoai+"')";
            thuchien(sql);
        }

        public void Update(Nhaxuatban nxb)
        {
            string sql = "update Nhaxuatban set Tennxb = '" + nxb.tennxb + "', Dienthoai = '" + nxb.dienthoai + "' where Manxb = " + nxb.manxb + "";
            thuchien(sql);
        }
        public void Delete(Nhaxuatban nxb)
        {
            string sql = "delete from Nhaxuatban where Manxb = '" + nxb.manxb + "'";
        }
    }
}
