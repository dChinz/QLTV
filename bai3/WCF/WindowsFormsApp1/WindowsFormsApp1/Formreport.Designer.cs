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
            this.comboBoxMaTG = new System.Windows.Forms.ComboBox();
            this.comboBoxMaNXB = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMaTG
            // 
            this.comboBoxMaTG.FormattingEnabled = true;
            this.comboBoxMaTG.Location = new System.Drawing.Point(178, 40);
            this.comboBoxMaTG.Name = "comboBoxMaTG";
            this.comboBoxMaTG.Size = new System.Drawing.Size(221, 37);
            this.comboBoxMaTG.TabIndex = 0;
            // 
            // comboBoxMaNXB
            // 
            this.comboBoxMaNXB.FormattingEnabled = true;
            this.comboBoxMaNXB.Location = new System.Drawing.Point(178, 99);
            this.comboBoxMaNXB.Name = "comboBoxMaNXB";
            this.comboBoxMaNXB.Size = new System.Drawing.Size(221, 37);
            this.comboBoxMaNXB.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(27, 177);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1122, 401);
            this.reportViewer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBoxMaNXB);
            this.Controls.Add(this.comboBoxMaTG);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Formreport";
            this.Text = "Formreport";
            this.Load += new System.EventHandler(this.Formreport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMaTG;
        private System.Windows.Forms.ComboBox comboBoxMaNXB;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
    }
}