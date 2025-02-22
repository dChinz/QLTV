using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhaxuatban
    {
        public int manxb { get; set; }
        public string tennxb { get; set; }
        public string dienthoai { get; set; }

        public Nhaxuatban() { }

        public Nhaxuatban(int manxb, string tennxb, string dienthoai)
        {
            this.manxb = manxb;
            this.tennxb = tennxb;
            this.dienthoai = dienthoai;
        }
        public Nhaxuatban(string tennxb, string dienthoai)
        {
            this.tennxb = tennxb;
            this.dienthoai = dienthoai;
        }
    }
}
