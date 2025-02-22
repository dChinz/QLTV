using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Nhaxuatban> Loadnxb();
        [OperationContract]
        void Insertnxb(Nhaxuatban nxb);
        [OperationContract]
        void Updatenxb(Nhaxuatban nxb);
        [OperationContract]
        void Deletenxb(Nhaxuatban nxb);
        [OperationContract]
        List<Tacgia> Loadtg();
        [OperationContract]
        void Inserttg(Tacgia tacgia);
        [OperationContract]
        void Updatetg(Tacgia tacgia);
        [OperationContract]
        void Deletetg(Tacgia tacgia);
        [OperationContract]
        List<Sach> Loadsach();
        [OperationContract]
        void Insertsach(Sach sach);
        [OperationContract]
        void Updatesach(Sach sach);
        [OperationContract]
        void Deletesach(Sach sach);

        [OperationContract]
        List<Report> data(string Tentg, string Tennxb);
    }
}
