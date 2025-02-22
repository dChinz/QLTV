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
    public partial class FormTG : Form
    {
        public FormTG()
        {
            InitializeComponent();
        }

        BUS_TG bus = new BUS_TG();
        Nhaxuatban nxb = new Nhaxuatban();

        private void FormTG_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.Loadtg();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tacgia tacgia = new Tacgia
            {
                tentg = textBoxTentg.Text,
                gioitinh = textBoxTentg.Text,
            };
            bus.Insert(tacgia);
            dataGridView1.DataSource = bus.Loadtg();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tacgia tacgia = new Tacgia
            {
                matg = Convert.ToInt32(label1.Text),
                tentg = textBoxTentg.Text,
                gioitinh = textBoxTentg.Text,
            };
            bus.Update(tacgia);
            dataGridView1.DataSource = bus.Loadtg();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tacgia tacgia = new Tacgia
            {
                matg = Convert.ToInt32(label1.Text),
                tentg = textBoxTentg.Text,
                gioitinh = textBoxTentg.Text,
            };
            bus.Delete(tacgia);
            dataGridView1.DataSource = bus.Loadtg();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTentg.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxGT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
