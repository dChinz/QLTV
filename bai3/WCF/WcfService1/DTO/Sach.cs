using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        public int masach {  get; set; }
        public string tensach { get; set; }

        public string chungloai { get; set; }
        public int manxb {  get; set; }
        public int matg { get; set; }   
        public double dongia { get; set; }

        public DateTime ngayxb { get; set; }

        public Sach () { }

        public Sach (int masach, string tensach, string chungloai, int manxb, int matg, double dongia, DateTime ngayxb)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.chungloai = chungloai;
            this.manxb = manxb;
            this.matg = matg;
            this.dongia = dongia;
            this.ngayxb = ngayxb;
        }
    }
}
