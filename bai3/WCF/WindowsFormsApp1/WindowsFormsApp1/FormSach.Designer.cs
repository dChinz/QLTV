namespace WindowsFormsApp1
{
    partial class FormSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMatg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxManxb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Masach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tensach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chungloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manxb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Matg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTensach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxChungloai = new System.Windows.Forms.TextBox();
            this.textBoxNgayxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Ngayxb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxDongia
            // 
            this.textBoxDongia.Location = new System.Drawing.Point(354, 221);
            this.textBoxDongia.Name = "textBoxDongia";
            this.textBoxDongia.Size = new System.Drawing.Size(438, 37);
            this.textBoxDongia.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 50;
            this.label6.Text = "Don gia";
            // 
            // comboBoxMatg
            // 
            this.comboBoxMatg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatg.FormattingEnabled = true;
            this.comboBoxMatg.Location = new System.Drawing.Point(354, 177);
            this.comboBoxMatg.Name = "comboBoxMatg";
            this.comboBoxMatg.Size = new System.Drawing.Size(438, 37);
            this.comboBoxMatg.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 48;
            this.label5.Text = "Matg";
            // 
            // comboBoxManxb
            // 
            this.comboBoxManxb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManxb.FormattingEnabled = true;
            this.comboBoxManxb.Location = new System.Drawing.Point(354, 134);
            this.comboBoxManxb.Name = "comboBoxManxb";
            this.comboBoxManxb.Size = new System.Drawing.Size(438, 37);
            this.comboBoxManxb.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "Manxb";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Masach,
            this.Tensach,
            this.Chungloai,
            this.Manxb,
            this.Matg,
            this.Dongia,
            this.Ngayxb});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(58, 391);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1086, 263);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Masach
            // 
            this.Masach.Text = "Mã Sách";
            this.Masach.Width = 166;
            // 
            // Tensach
            // 
            this.Tensach.Text = "Tên Sách";
            this.Tensach.Width = 170;
            // 
            // Chungloai
            // 
            this.Chungloai.Text = "Chủng loại";
            this.Chungloai.Width = 184;
            // 
            // Manxb
            // 
            this.Manxb.Text = "Mã NXB";
            this.Manxb.Width = 128;
            // 
            // Matg
            // 
            this.Matg.Text = "Mã TG";
            this.Matg.Width = 123;
            // 
            // Dongia
            // 
            this.Dongia.Text = "Đơn giá";
            this.Dongia.Width = 132;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 52);
            this.button3.TabIndex = 44;
            this.button3.Text = "Xoa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 52);
            this.button2.TabIndex = 43;
            this.button2.Text = "Sua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 52);
            this.button1.TabIndex = 42;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "Chung loai";
            // 
            // textBoxTensach
            // 
            this.textBoxTensach.Location = new System.Drawing.Point(354, 48);
            this.textBoxTensach.Name = "textBoxTensach";
            this.textBoxTensach.Size = new System.Drawing.Size(438, 37);
            this.textBoxTensach.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ten Sach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            // 
            // textBoxChungloai
            // 
            this.textBoxChungloai.Location = new System.Drawing.Point(354, 92);
            this.textBoxChungloai.Name = "textBoxChungloai";
            this.textBoxChungloai.Size = new System.Drawing.Size(438, 37);
            this.textBoxChungloai.TabIndex = 41;
            // 
            // textBoxNgayxb
            // 
            this.textBoxNgayxb.Location = new System.Drawing.Point(354, 262);
            this.textBoxNgayxb.Name = "textBoxNgayxb";
            this.textBoxNgayxb.Size = new System.Drawing.Size(438, 37);
            this.textBoxNgayxb.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 52;
            this.label7.Text = "Ngay xb";
            // 
            // Ngayxb
            // 
            this.Ngayxb.Text = "Ngày Xuất bản";
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.textBoxNgayxb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDongia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMatg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxManxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTensach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxChungloai);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormSach";
            this.Text = "FormSach";
            this.Load += new System.EventHandler(this.FormSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMatg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxManxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Masach;
        private System.Windows.Forms.ColumnHeader Tensach;
        private System.Windows.Forms.ColumnHeader Chungloai;
        private System.Windows.Forms.ColumnHeader Manxb;
        private System.Windows.Forms.ColumnHeader Matg;
        private System.Windows.Forms.ColumnHeader Dongia;
        private System.Windows.Forms.ColumnHeader Ngayxb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTensach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxChungloai;
        private System.Windows.Forms.TextBox textBoxNgayxb;
        private System.Windows.Forms.Label label7;
    }
}