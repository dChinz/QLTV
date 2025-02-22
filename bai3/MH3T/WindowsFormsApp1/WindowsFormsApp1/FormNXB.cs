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
    public partial class FormNXB : Form
    {
        public FormNXB()
        {
            InitializeComponent();
        }

        Nhaxuatban nxb = new Nhaxuatban();
        BUS_NXB bus = new BUS_NXB();

        private void FormNXB_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.Loadnxb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nhaxuatban nhaxuatban = new Nhaxuatban
            {
                tennxb = textBoxTennxb.Text,
                dienthoai = textBoxDT.Text,
            };
            bus.Insert(nhaxuatban);
            dataGridView1.DataSource = bus.Loadnxb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nhaxuatban nhaxuatban = new Nhaxuatban
            {
                manxb = Convert.ToInt32(label3.Text),
                tennxb = textBoxTennxb.Text,
                dienthoai = textBoxDT.Text,
            };
            bus.Update(nhaxuatban);
            dataGridView1.DataSource = bus.Loadnxb();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nhaxuatban nhaxuatban = new Nhaxuatban
            {
                manxb = Convert.ToInt32(label3.Text),
                tennxb = textBoxTennxb.Text,
                dienthoai = textBoxDT.Text,
            };
            bus.Delete(nhaxuatban);
            dataGridView1.DataSource = bus.Loadnxb();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTennxb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxDT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
