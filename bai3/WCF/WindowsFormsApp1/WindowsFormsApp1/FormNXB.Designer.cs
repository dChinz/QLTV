namespace WindowsFormsApp1
{
    partial class FormNXB
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTennxb = new System.Windows.Forms.TextBox();
            this.textBoxDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Manxb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tennxb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dienthoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten NXB";
            // 
            // textBoxTennxb
            // 
            this.textBoxTennxb.Location = new System.Drawing.Point(281, 95);
            this.textBoxTennxb.Name = "textBoxTennxb";
            this.textBoxTennxb.Size = new System.Drawing.Size(360, 37);
            this.textBoxTennxb.TabIndex = 1;
            // 
            // textBoxDT
            // 
            this.textBoxDT.Location = new System.Drawing.Point(281, 151);
            this.textBoxDT.Name = "textBoxDT";
            this.textBoxDT.Size = new System.Drawing.Size(360, 37);
            this.textBoxDT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dien Thoai";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(493, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 65);
            this.button3.TabIndex = 6;
            this.button3.Text = "Xoa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(688, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 65);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Manxb,
            this.Tennxb,
            this.Dienthoai});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(84, 387);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(931, 242);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Manxb
            // 
            this.Manxb.Text = "Mã NXB";
            this.Manxb.Width = 196;
            // 
            // Tennxb
            // 
            this.Tennxb.Text = "Tên NXB";
            this.Tennxb.Width = 278;
            // 
            // Dienthoai
            // 
            this.Dienthoai.Text = "Điện thoại";
            this.Dienthoai.Width = 182;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // FormNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTennxb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormNXB";
            this.Text = "FormNXB";
            this.Load += new System.EventHandler(this.FormNXB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTennxb;
        private System.Windows.Forms.TextBox textBoxDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Manxb;
        private System.Windows.Forms.ColumnHeader Tennxb;
        private System.Windows.Forms.ColumnHeader Dienthoai;
        private System.Windows.Forms.Label label3;
    }
}