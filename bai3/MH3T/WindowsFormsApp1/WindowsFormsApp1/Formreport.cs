using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    public partial class Formreport : Form
    {
        public Formreport()
        {
            InitializeComponent();
        }
        BUS_S bus = new BUS_S();
        BUS_NXB busnxb = new BUS_NXB();
        BUS_TG bustg = new BUS_TG();
        Sach s = new Sach();

        private void Formreport_Load(object sender, EventArgs e)
        {
            comboBoxManxb.DataSource = busnxb.Loadnxb();
            comboBoxManxb.DisplayMember = "tennxb";
            comboBoxManxb.ValueMember = "tennxb";
            comboBoxManxb.SelectedIndex = -1;

            comboBoxMatg.DataSource = bustg.Loadtg();
            comboBoxMatg.DisplayMember = "tentg";
            comboBoxMatg.ValueMember = "tentg";
            comboBoxMatg.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = bus.data(comboBoxMatg.Text, comboBoxManxb.Text);

            reportViewer1.LocalReport.ReportPath = @"D:\LapTrinhService\MH3TVSWCF\bai3\MH3T\WindowsFormsApp1\WindowsFormsApp1\Report1.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", data);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
