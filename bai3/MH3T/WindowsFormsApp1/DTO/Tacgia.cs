using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tacgia
    {
        public int matg { get; set; }
        public string tentg { get; set; }

        public string gioitinh { get; set; }

        public Tacgia() { }

        public Tacgia(int matg, string tentg, string gioitinh)
        {
            this.matg = matg;
            this.tentg = tentg;
            this.gioitinh = gioitinh;
        }

        public Tacgia(string tentg, string gioitinh)
        {
            this.tentg = tentg;
            this.gioitinh = gioitinh;
        }
    }
}
