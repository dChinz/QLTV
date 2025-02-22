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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormTG : Form
    {
        public FormTG()
        {
            InitializeComponent();
        }
        
        Service1Client client = new Service1Client();

        private void FormTG_Load(object sender, EventArgs e)
        {
            List<ServiceReference1.Tacgia> tacgias = client.Loadtg().ToList();

            foreach (var sp in tacgias)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(sp.matg).ToString());
                lv.SubItems.Add(sp.tentg);
                lv.SubItems.Add(sp.gioitinh);
                listView1.Items.Add(lv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tacgia tacgia = new Tacgia
            {
                tentg = textBoxTentg.Text,
                gioitinh = comboBoxGT.Text,
            };
            client.Inserttg(tacgia);
            listView1.Items.Clear();
            var customers = client.Loadtg();
            foreach (var cus in customers) 
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(cus.matg).ToString());
                lv.SubItems.Add(cus.tentg);
                lv.SubItems.Add(cus.gioitinh);
                listView1.Items.Add(lv);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tacgia tacgia = new Tacgia
            {
                matg = Convert.ToInt32(label3.Text),
                tentg = textBoxTentg.Text,
                gioitinh = comboBoxGT.Text,
            };
            client.Updatetg(tacgia);
            listView1.Items.Clear();
            var customers = client.Loadtg();
            foreach (var cus in customers)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(cus.matg).ToString());
                lv.SubItems.Add(cus.tentg);
                lv.SubItems.Add(cus.gioitinh);
                listView1.Items.Add(lv);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tacgia tacgia = new Tacgia
            {
                matg = Convert.ToInt32(label3.Text),
                tentg = textBoxTentg.Text,
                gioitinh = comboBoxGT.Text,
            };
            client.Deletetg(tacgia);
            listView1.Items.Clear();
            var customers = client.Loadtg();
            foreach (var cus in customers)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(cus.matg).ToString());
                lv.SubItems.Add(cus.tentg);
                lv.SubItems.Add(cus.gioitinh);
                listView1.Items.Add(lv);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nxb = client.Loadtg();
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];

                label3.Text = lv.SubItems[0].Text;
                textBoxTentg.Text = lv.SubItems[1].Text;
                comboBoxGT.Text = lv.SubItems[2].Text;
            }
        }
    }
}
