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
    public partial class FormNXB : Form
    {
        public FormNXB()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void FormNXB_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<ServiceReference1.Nhaxuatban> nhaxuatbans = client.Loadnxb().ToList();

            foreach (var sp in nhaxuatbans)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(sp.manxb).ToString());
                lv.SubItems.Add(sp.tennxb);
                lv.SubItems.Add(sp.dienthoai);
                listView1.Items.Add(lv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sdt = textBoxDT.Text;
            if(sdt.Length > 10)
            {
                MessageBox.Show("sdt khong phu hop");
                return;
            }

            Nhaxuatban nhaxuatban = new Nhaxuatban
            {
                tennxb = textBoxTennxb.Text,
                dienthoai = textBoxDT.Text
            };
            client.Insertnxb(nhaxuatban);
            listView1.Items.Clear();
            var customers = client.Loadnxb();
            foreach (var cus in customers)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(cus.manxb).ToString());
                lv.SubItems.Add(cus.tennxb);
                lv.SubItems.Add(cus.dienthoai);
                listView1.Items.Add(lv);
            }
            listView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nhaxuatban nhaxuatban = new Nhaxuatban
            {
                manxb = Convert.ToInt32( label3.Text),
                tennxb = textBoxTennxb.Text,
                dienthoai = textBoxDT.Text
            };
            client.Updatenxb(nhaxuatban);
            listView1.Items.Clear();
            var customers = client.Loadnxb();
            foreach (var cus in customers)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(cus.manxb).ToString());
                lv.SubItems.Add(cus.tennxb);
                lv.SubItems.Add(cus.dienthoai);
                listView1.Items.Add(lv);
            }
            listView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nhaxuatban nhaxuatban = new Nhaxuatban
            {
                manxb = Convert.ToInt32(label3.Text),
                tennxb = textBoxTennxb.Text,
                dienthoai = textBoxDT.Text
            };
            client.Deletenxb(nhaxuatban);
            listView1.Items.Clear();
            var customers = client.Loadnxb();
            foreach (var cus in customers)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(cus.manxb).ToString());
                lv.SubItems.Add(cus.tennxb);
                lv.SubItems.Add(cus.dienthoai);
                listView1.Items.Add(lv);
            }
            listView1.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nxb = client.Loadnxb();
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];

                label3.Text = lv.SubItems[0].Text;
                textBoxTennxb.Text = lv.SubItems[1].Text;
                textBoxDT.Text = lv.SubItems[2].Text;
            }
        }
    }
}
