namespace DSLR_CameraStore
{
    partial class formLoginn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.crystalReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReportLogin1 = new DSLR_CameraStore.ReportLogin();
            this.ReportLogin2 = new DSLR_CameraStore.ReportLogin();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPrint);
            this.panel1.Controls.Add(this.btn_Print);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 82);
            this.panel1.TabIndex = 0;
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(43, 41);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(100, 20);
            this.txtPrint.TabIndex = 1;
            this.txtPrint.Text = "Username";
            this.txtPrint.Click += new System.EventHandler(this.txtPrint_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(202, 39);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 2;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // crystalReport
            // 
            this.crystalReport.ActiveViewIndex = 0;
            this.crystalReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.crystalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReport.Location = new System.Drawing.Point(0, 88);
            this.crystalReport.Name = "crystalReport";
            this.crystalReport.ReportSource = this.ReportLogin2;
            this.crystalReport.Size = new System.Drawing.Size(739, 31);
            this.crystalReport.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 158);
            this.panel2.TabIndex = 2;
            // 
            // formLoginn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 283);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.crystalReport);
            this.Controls.Add(this.panel1);
            this.Name = "formLoginn";
            this.Text = "formLoginn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Button btn_Print;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReport;
        private System.Windows.Forms.Panel panel2;
        private ReportLogin ReportLogin1;
        private ReportLogin ReportLogin2;
    }
}