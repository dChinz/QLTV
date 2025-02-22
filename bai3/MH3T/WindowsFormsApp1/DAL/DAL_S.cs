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
    public class DAL_S : ketnoi
    {
        public DataTable Loads()
        {
            return Load("select * from Sach");
        }

        public void Insert(Sach sach)
        {
            string sql = "insert into Sach values ('" + sach.tensach + "', '" + sach.chungloai + "', " + sach.manxb + ", " + sach.matg + ", " + sach.dongia + ", '" + sach.ngayxb + "')";
            thuchien(sql);
        }
        public void Update(Sach sach)
        {
            string sql = "update Sach set Tensach = '" + sach.tensach + "', Chungloai = '" + sach.chungloai + "', Manxb = " + sach.manxb + ", Matg = " + sach.matg + ", Dongia = " + sach.dongia + ", Ngayxb = '" + sach.ngayxb + "' where Masach = " + sach.masach + "";
            thuchien(sql);
        }

        public void Delete(Sach sach)
        {
            string sql = "delete from Sach where Masach = " + sach.masach + "";
            thuchien(sql);
        }

        public DataTable data(string Tentg, string Tennxb)
        {
            string sql = @"SELECT Sach.Tensach, Tacgia.Tentg, Nhaxuatban.Tennxb, Sach.Masach, Sach.Dongia, Sach.Chungloai, Sach.Ngayxb
                   FROM Sach 
                   INNER JOIN Tacgia ON Sach.Matg = Tacgia.Matg
                   INNER JOIN Nhaxuatban ON Sach.Manxb = Nhaxuatban.Manxb
                   WHERE (Tacgia.Tentg = @Tentg) AND (Nhaxuatban.Tennxb = @Tennxb)";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLThuvien;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Tentg", Tentg);
            cmd.Parameters.AddWithValue("@Tennxb", Tennxb);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
