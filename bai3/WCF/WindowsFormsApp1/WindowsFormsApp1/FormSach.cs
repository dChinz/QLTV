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
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void FormSach_Load(object sender, EventArgs e)
        {
            List<ServiceReference1.Sach> saches = client.Loadsach().ToList();
            listView1.Items.Clear();

            foreach (var sp in saches)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32( sp.masach).ToString());
                lv.SubItems.Add(sp.tensach);
                lv.SubItems.Add(sp.chungloai);
                lv.SubItems.Add(Convert.ToInt32(sp.manxb).ToString());
                lv.SubItems.Add(Convert.ToInt32(sp.matg).ToString());
                lv.SubItems.Add(Convert.ToInt32(sp.dongia).ToString());
                lv.SubItems.Add(Convert.ToDateTime(sp.ngayxb).ToString());
                listView1.Items.Add(lv);
            }

            List<ServiceReference1.Tacgia> tacgias = client.Loadtg().ToList();
            comboBoxMatg.DataSource = tacgias;
            comboBoxMatg.DisplayMember = "matg";
            comboBoxMatg.ValueMember = "matg";
            comboBoxMatg.SelectedIndex = -1;

            List<ServiceReference1.Nhaxuatban> chucvus = client.Loadnxb().ToList();
            comboBoxManxb.DataSource = chucvus;
            comboBoxManxb.DisplayMember = "manxb";
            comboBoxManxb.ValueMember = "manxb";
            comboBoxManxb.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gia = Convert.ToDouble(textBoxDongia.Text);
            if(gia <= 0)
            {
                MessageBox.Show("don gia phai lon hon 0");
                return;
            }
            var ngay = Convert.ToDateTime(textBoxNgayxb.Text);
            if(ngay > DateTime.Now)
            {
                MessageBox.Show("ngay nay chua toi");
                return;
            }

            Sach sach = new Sach
            {
                tensach = textBoxTensach.Text,
                chungloai = textBoxChungloai.Text,
                manxb = Convert.ToInt32(comboBoxManxb.SelectedValue.ToString()),
                matg = Convert.ToInt32(comboBoxMatg.SelectedValue.ToString()),
                dongia = Convert.ToDouble( textBoxDongia.Text),
                ngayxb = Convert.ToDateTime(textBoxNgayxb.Text),
            };
            client.Insertsach(sach);
            listView1.Items.Clear();
            var customers = client.Loadsach().ToList();
            foreach (var sp in customers) 
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(sp.masach).ToString());
                lv.SubItems.Add(sp.tensach);
                lv.SubItems.Add(sp.chungloai);
                lv.SubItems.Add(Convert.ToInt32(sp.manxb).ToString());
                lv.SubItems.Add(Convert.ToInt32(sp.matg).ToString());
                lv.SubItems.Add(Convert.ToInt32(sp.dongia).ToString());
                lv.SubItems.Add(Convert.ToDateTime(sp.ngayxb).ToString());
                listView1.Items.Add(lv);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach
            {
                masach = Convert.ToInt32(label1.Text),
                tensach = textBoxTensach.Text,
                chungloai = textBoxChungloai.Text,
                manxb = Convert.ToInt32(comboBoxManxb.SelectedValue.ToString()),
                matg = Convert.ToInt32(comboBoxMatg.SelectedValue.ToString()),
                dongia = Convert.ToDouble(textBoxDongia.Text),
                ngayxb = Convert.ToDateTime(textBoxNgayxb.Text),
            };
            client.Updatesach(sach);
            listView1.Items.Clear();
            var customers = client.Loadsach().ToList();
            foreach (var sp in customers)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(sp.masach).ToString());
                lv.SubItems.Add(sp.tensach);
                lv.SubItems.Add(sp.chungloai);
                lv.SubItems.Add(Convert.ToInt32(sp.manxb).ToString());
                lv.SubItems.Add(Convert.ToInt32(sp.matg).ToString());
                lv.SubItems.Add(Convert.ToInt32(sp.dongia).ToString());
                lv.SubItems.Add(Convert.ToDateTime(sp.ngayxb).ToString());
                listView1.Items.Add(lv);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach
            {
                masach = Convert.ToInt32(label1.Text),
                tensach = textBoxTensach.Text,
                chungloai = textBoxChungloai.Text,
                manxb = Convert.ToInt32(comboBoxManxb.SelectedValue.ToString()),
                matg = Convert.ToInt32(comboBoxMatg.SelectedValue.ToString()),
                dongia = Convert.ToDouble(textBoxDongia.Text),
                ngayxb = Convert.ToDateTime(textBoxNgayxb.Text),
            };
            client.Deletesach(sach);
            listView1.Items.Clear();
            var customers = client.Loadsach().ToList();
            foreach (var sp in customers)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(sp.masach).ToString());
                lv.SubItems.Add(sp.tensach);
                lv.SubItems.Add(sp.chungloai);
                lv.SubItems.Add(Convert.ToInt32(sp.manxb).ToString());
                lv.SubItems.Add(Convert.ToInt32(sp.matg).ToString());
                lv.SubItems.Add(Convert.ToInt32(sp.dongia).ToString());
                lv.SubItems.Add(Convert.ToDateTime(sp.ngayxb).ToString());
                listView1.Items.Add(lv);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ServiceReference1.Sach> saches = client.Loadsach().ToList();

            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];

                label1.Text = lv.SubItems[0].ToString();
                textBoxTensach.Text = lv.SubItems[1].ToString();
                textBoxChungloai.Text = lv.SubItems[2].ToString();
                comboBoxManxb.SelectedValue = int.Parse(lv.SubItems[3].Text);
                comboBoxMatg.SelectedValue =int.Parse(lv.SubItems[4].Text);
                textBoxDongia.Text = lv.SubItems[5].Text.Trim();
                textBoxNgayxb.Text = lv.SubItems[6].Text.Trim();
            }
        }
    }
}
