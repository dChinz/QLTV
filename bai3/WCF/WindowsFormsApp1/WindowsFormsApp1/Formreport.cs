using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class Formreport : Form
    {
        public Formreport()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void Formreport_Load(object sender, EventArgs e)
        {
            List<ServiceReference1.Tacgia> tacgias = client.Loadtg().ToList();
            comboBoxMaTG.DataSource = tacgias;
            comboBoxMaTG.DisplayMember = "tentg";
            comboBoxMaTG.ValueMember = "tentg";
            comboBoxMaTG.SelectedIndex = -1;

            List<ServiceReference1.Nhaxuatban> chucvus = client.Loadnxb().ToList();
            comboBoxMaNXB.DataSource = chucvus;
            comboBoxMaNXB.DisplayMember = "tennxb";
            comboBoxMaNXB.ValueMember = "tennxb";
            comboBoxMaNXB.SelectedIndex = -1;

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<ServiceReference1.Report> data = client.data(comboBoxMaTG.Text, comboBoxMaNXB.Text).ToList();

            reportViewer1.LocalReport.ReportPath = @"D:\LapTrinhService\MH3TVSWCF\bai3\WindowsFormsApp1\WindowsFormsApp1\Report1.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", data);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
