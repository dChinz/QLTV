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

namespace WindowsFormsApp1
{
    public partial class FormS : Form
    {
        public FormS()
        {
            InitializeComponent();
        }

        BUS_S bus = new BUS_S();
        BUS_NXB busnxb = new BUS_NXB();
        BUS_TG bustg = new BUS_TG();
        Sach s = new Sach();

        private void FormS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.Loads();

            comboBoxManxb.DataSource = busnxb.Loadnxb();
            comboBoxManxb.DisplayMember = "manxb";
            comboBoxManxb.ValueMember = "manxb";
            comboBoxManxb.SelectedIndex = -1;

            comboBoxMatg.DataSource = bustg.Loadtg();
            comboBoxMatg.DisplayMember = "matg";
            comboBoxMatg.ValueMember = "matg";
            comboBoxMatg.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gia = Convert.ToDouble(textBoxDongia.Text);
            if (gia <= 0)
            {
                MessageBox.Show("don gia phai lon hon 0");
                return;
            }
            var ngay = Convert.ToDateTime(dateTimePicker1.Text);
            if (ngay > DateTime.Now)
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
                dongia = Convert.ToDouble(textBoxDongia.Text),
                ngayxb = Convert.ToDateTime(dateTimePicker1.Text)
            };
            bus.Insert(sach);
            dataGridView1.DataSource = bus.Loads();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var gia = Convert.ToDouble(textBoxDongia.Text);
            if (gia <= 0)
            {
                MessageBox.Show("don gia phai lon hon 0");
                return;
            }
            var ngay = Convert.ToDateTime(dateTimePicker1.Text);
            if (ngay > DateTime.Now)
            {
                MessageBox.Show("ngay nay chua toi");
                return;
            }
            Sach sach = new Sach
            {
                masach = Convert.ToInt32(label1.Text),
                tensach = textBoxTensach.Text,
                chungloai = textBoxChungloai.Text,
                manxb = Convert.ToInt32(comboBoxManxb.SelectedValue.ToString()),
                matg = Convert.ToInt32(comboBoxMatg.SelectedValue.ToString()),
                dongia = Convert.ToDouble(textBoxDongia.Text),
                ngayxb = Convert.ToDateTime(dateTimePicker1.Text)
            };
            bus.Update(sach);
            dataGridView1.DataSource = bus.Loads();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var gia = Convert.ToDouble(textBoxDongia.Text);
            if (gia <= 0)
            {
                MessageBox.Show("don gia phai lon hon 0");
                return;
            }
            var ngay = Convert.ToDateTime(dateTimePicker1.Text);
            if (ngay > DateTime.Now)
            {
                MessageBox.Show("ngay nay chua toi");
                return;
            }
            Sach sach = new Sach
            {
                masach = Convert.ToInt32(label1.Text),
                tensach = textBoxTensach.Text,
                chungloai = textBoxChungloai.Text,
                manxb = Convert.ToInt32(comboBoxManxb.SelectedValue.ToString()),
                matg = Convert.ToInt32(comboBoxMatg.SelectedValue.ToString()),
                dongia = Convert.ToDouble(textBoxDongia.Text),
                ngayxb = Convert.ToDateTime(dateTimePicker1.Text)
            };
            bus.Delete(sach);
            dataGridView1.DataSource = bus.Loads();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTensach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxChungloai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxManxb.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxMatg.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxDongia.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
