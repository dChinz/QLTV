namespace WindowsFormsApp1
{
    partial class Formreport
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxManxb = new System.Windows.Forms.ComboBox();
            this.comboBoxMatg = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxManxb
            // 
            this.comboBoxManxb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManxb.FormattingEnabled = true;
            this.comboBoxManxb.Location = new System.Drawing.Point(90, 89);
            this.comboBoxManxb.Name = "comboBoxManxb";
            this.comboBoxManxb.Size = new System.Drawing.Size(221, 37);
            this.comboBoxManxb.TabIndex = 5;
            // 
            // comboBoxMatg
            // 
            this.comboBoxMatg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatg.FormattingEnabled = true;
            this.comboBoxMatg.Location = new System.Drawing.Point(90, 30);
            this.comboBoxMatg.Name = "comboBoxMatg";
            this.comboBoxMatg.Size = new System.Drawing.Size(221, 37);
            this.comboBoxMatg.TabIndex = 4;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(34, 205);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1122, 401);
            this.reportViewer1.TabIndex = 7;
            // 
            // Formreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxManxb);
            this.Controls.Add(this.comboBoxMatg);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Formreport";
            this.Text = "Formreport";
            this.Load += new System.EventHandler(this.Formreport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxManxb;
        private System.Windows.Forms.ComboBox comboBoxMatg;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}