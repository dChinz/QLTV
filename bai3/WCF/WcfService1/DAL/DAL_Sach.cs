using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Sach: ketnoi
    {
        Sach sach = new Sach();

        public List<Sach> Loadsach()
        {
            List<Sach> saches = new List<Sach>();
            DataTable dt = Load("select * from Sach");
            foreach (DataRow dr in dt.Rows)
            {
                Sach sach = new Sach
                {
                    masach = Convert.ToInt32(dr["Masach"].ToString()),
                    tensach = dr["Tensach"].ToString(),
                    chungloai = dr["Chungloai"].ToString(),
                    manxb = Convert.ToInt32(dr["Manxb"].ToString()),
                    matg = Convert.ToInt32(dr["Matg"].ToString()),
                    dongia = Convert.ToDouble(dr["Dongia"].ToString()),
                    ngayxb = Convert.ToDateTime(dr["Ngayxb"].ToString())
                };
                saches.Add(sach);
            }
            return saches;
        }

        public void Insert(Sach sach)
        {
            string sql = "insert into Sach values ('" + sach.tensach + "', '" + sach.chungloai + "', " + sach.manxb + ", " + sach.matg + ", " + sach.dongia + ", '" + sach.ngayxb + "')";
            thuchien(sql);
        }
        public void Update(Sach sach)
        {
            string sql = "update Sach set Tensach = '" + sach.tensach + "', Chungloai = '" + sach.chungloai + "', Manxb = " + sach.manxb + ", Matg = " + sach.matg + ", Dongia = " + sach.dongia + ", Ngayxb = '" + sach.ngayxb + "' where Masach = "+sach.masach+"";
            thuchien(sql);
        }

        public void Delete(Sach sach)
        {
            string sql = "delete from Sach where Masach = " + sach.masach + "";
            thuchien(sql);
        }

        public List<Report> data(string Tentg, string Tennxb)
        {
            List<Report> list = new List<Report>();

            string sql = @"SELECT Sach.Tensach, Tacgia.Tentg, Nhaxuatban.Tennxb
                   FROM Sach 
                   INNER JOIN Tacgia ON Sach.Matg = Tacgia.Matg
                   INNER JOIN Nhaxuatban ON Sach.Manxb = Nhaxuatban.Manxb
                   WHERE (Tacgia.Tentg = @Tentg) AND (Nhaxuatban.Tennxb = @Tennxb)";

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLThuvien;Integrated Security=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Tentg", Tentg);
                    cmd.Parameters.AddWithValue("@Tennxb", Tennxb);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(new Report
                            {
                                tensach = dr["Tensach"].ToString(),
                                tentg = dr["Tentg"].ToString(),
                                tennxb = dr["Tennxb"].ToString(),
                            });
                        }
                    }
                }
            }

            return list;
        }

    }
}
