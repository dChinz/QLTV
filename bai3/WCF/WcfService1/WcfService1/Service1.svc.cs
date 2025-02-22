using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DTO;
using DAL;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DAL_NXB dalnxb = new DAL_NXB();
        public List<Nhaxuatban> Loadnxb()
        {
            return dalnxb.Loadnxb();
        }

        public void Insertnxb(Nhaxuatban a)
        {
            dalnxb.Insert(a);
        }

        public void Updatenxb(Nhaxuatban a)
        {
            dalnxb.Update(a);
        }

        public void Deletenxb(Nhaxuatban a)
        {
            dalnxb.Delete(a);
        }

        DAL_TG daltg = new DAL_TG();
        public List<Tacgia> Loadtg()
        {
            return daltg.Loadtg();
        }

        public void Inserttg(Tacgia b)
        {
            daltg.Insert(b);
        }

        public void Updatetg(Tacgia b)
        {
            daltg.Update(b);
        }

        public void Deletetg(Tacgia b)
        {
            daltg.Delete(b);
        }

        DAL_Sach dalsach = new DAL_Sach();

        public List<Sach> Loadsach()
        {
            return dalsach.Loadsach();
        }

        public void Insertsach(Sach sach)
        {
            dalsach.Insert(sach);
        }

        public void Updatesach(Sach sach)
        {
            dalsach.Update(sach);
        }

        public void Deletesach(Sach sach)
        {
            dalsach.Delete(sach);
        }

        public List<Report> data(string Tentg, string Tennxb)
        {
            return dalsach.data(Tentg, Tennxb);
        }
    }
}
