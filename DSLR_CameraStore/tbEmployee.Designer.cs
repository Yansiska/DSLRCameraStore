namespace DSLR_CameraStore
{
    partial class tbEmployee
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
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddE = new System.Windows.Forms.Button();
            this.btnDeleteE = new System.Windows.Forms.Button();
            this.btnUpdateE = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDEmployee = new System.Windows.Forms.TextBox();
            this.txtEmailE = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPhoneE = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblIdProduct = new System.Windows.Forms.Label();
            this.txtAddresE = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtNameE = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cb_Position = new System.Windows.Forms.ComboBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmployee
            // 
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Location = new System.Drawing.Point(293, 8);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.Size = new System.Drawing.Size(425, 285);
            this.dgEmployee.TabIndex = 132;
            this.dgEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployee_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 130;
            this.label2.Text = "Position";
            // 
            // btnAddE
            // 
            this.btnAddE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.btnAddE.BackgroundImage = global::DSLR_CameraStore.Properties.Resources.Save_Button;
            this.btnAddE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddE.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddE.Location = new System.Drawing.Point(105, 314);
            this.btnAddE.Name = "btnAddE";
            this.btnAddE.Size = new System.Drawing.Size(38, 37);
            this.btnAddE.TabIndex = 129;
            this.btnAddE.UseVisualStyleBackColor = false;
            this.btnAddE.Click += new System.EventHandler(this.btnAddE_Click);
            // 
            // btnDeleteE
            // 
            this.btnDeleteE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.btnDeleteE.BackgroundImage = global::DSLR_CameraStore.Properties.Resources.delete;
            this.btnDeleteE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteE.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteE.Location = new System.Drawing.Point(196, 314);
            this.btnDeleteE.Name = "btnDeleteE";
            this.btnDeleteE.Size = new System.Drawing.Size(36, 37);
            this.btnDeleteE.TabIndex = 128;
            this.btnDeleteE.UseVisualStyleBackColor = false;
            this.btnDeleteE.Click += new System.EventHandler(this.btnDeleteE_Click);
            // 
            // btnUpdateE
            // 
            this.btnUpdateE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.btnUpdateE.BackgroundImage = global::DSLR_CameraStore.Properties.Resources.diskette;
            this.btnUpdateE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateE.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateE.Location = new System.Drawing.Point(152, 314);
            this.btnUpdateE.Name = "btnUpdateE";
            this.btnUpdateE.Size = new System.Drawing.Size(36, 37);
            this.btnUpdateE.TabIndex = 127;
            this.btnUpdateE.UseVisualStyleBackColor = false;
            this.btnUpdateE.Click += new System.EventHandler(this.btnUpdateE_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.btn_Back.BackgroundImage = global::DSLR_CameraStore.Properties.Resources.back_Employee_;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(-1, 309);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(48, 50);
            this.btn_Back.TabIndex = 126;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 125;
            this.label1.Text = "ID_Employee";
            // 
            // txtIDEmployee
            // 
            this.txtIDEmployee.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEmployee.Location = new System.Drawing.Point(105, 8);
            this.txtIDEmployee.Name = "txtIDEmployee";
            this.txtIDEmployee.Size = new System.Drawing.Size(141, 25);
            this.txtIDEmployee.TabIndex = 124;
            // 
            // txtEmailE
            // 
            this.txtEmailE.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailE.Location = new System.Drawing.Point(105, 268);
            this.txtEmailE.Name = "txtEmailE";
            this.txtEmailE.Size = new System.Drawing.Size(141, 25);
            this.txtEmailE.TabIndex = 123;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(13, 270);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 18);
            this.lblPrice.TabIndex = 122;
            this.lblPrice.Text = "Email";
            // 
            // txtPhoneE
            // 
            this.txtPhoneE.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneE.Location = new System.Drawing.Point(105, 221);
            this.txtPhoneE.Name = "txtPhoneE";
            this.txtPhoneE.Size = new System.Drawing.Size(141, 25);
            this.txtPhoneE.TabIndex = 121;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(13, 224);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(84, 18);
            this.lblQty.TabIndex = 120;
            this.lblQty.Text = "Phone_Number";
            // 
            // lblIdProduct
            // 
            this.lblIdProduct.AutoSize = true;
            this.lblIdProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblIdProduct.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduct.Location = new System.Drawing.Point(13, 178);
            this.lblIdProduct.Name = "lblIdProduct";
            this.lblIdProduct.Size = new System.Drawing.Size(44, 18);
            this.lblIdProduct.TabIndex = 118;
            this.lblIdProduct.Text = "Gender";
            // 
            // txtAddresE
            // 
            this.txtAddresE.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddresE.Location = new System.Drawing.Point(105, 90);
            this.txtAddresE.Name = "txtAddresE";
            this.txtAddresE.Size = new System.Drawing.Size(141, 25);
            this.txtAddresE.TabIndex = 117;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 91);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 18);
            this.lblAddress.TabIndex = 116;
            this.lblAddress.Text = "Address";
            // 
            // txtNameE
            // 
            this.txtNameE.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameE.Location = new System.Drawing.Point(105, 49);
            this.txtNameE.Name = "txtNameE";
            this.txtNameE.Size = new System.Drawing.Size(141, 25);
            this.txtNameE.TabIndex = 115;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 18);
            this.lblName.TabIndex = 114;
            this.lblName.Text = "Name";
            // 
            // cb_Position
            // 
            this.cb_Position.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Position.FormattingEnabled = true;
            this.cb_Position.Items.AddRange(new object[] {
            "Admin",
            "Finance",
            "HRD",
            "Office Boy",
            "Office Girl",
            "Secretary",
            "Manager"});
            this.cb_Position.Location = new System.Drawing.Point(105, 134);
            this.cb_Position.Name = "cb_Position";
            this.cb_Position.Size = new System.Drawing.Size(141, 26);
            this.cb_Position.TabIndex = 133;
            this.cb_Position.SelectedIndexChanged += new System.EventHandler(this.cb_Position_SelectedIndexChanged);
            // 
            // cb_gender
            // 
            this.cb_gender.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Finance",
            "HRD",
            "Office Boy",
            "Office Girl",
            "Secretary",
            "Manager"});
            this.cb_gender.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cb_gender.Location = new System.Drawing.Point(105, 176);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(141, 26);
            this.cb_gender.TabIndex = 134;
            // 
            // tbEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DSLR_CameraStore.Properties.Resources.Employee_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 535);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.cb_Position);
            this.Controls.Add(this.dgEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddE);
            this.Controls.Add(this.btnDeleteE);
            this.Controls.Add(this.btnUpdateE);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDEmployee);
            this.Controls.Add(this.txtEmailE);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPhoneE);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblIdProduct);
            this.Controls.Add(this.txtAddresE);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtNameE);
            this.Controls.Add(this.lblName);
            this.Name = "tbEmployee";
            this.Text = "tbEmployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tbEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddE;
        private System.Windows.Forms.Button btnDeleteE;
        private System.Windows.Forms.Button btnUpdateE;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDEmployee;
        private System.Windows.Forms.TextBox txtEmailE;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPhoneE;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblIdProduct;
        private System.Windows.Forms.TextBox txtAddresE;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtNameE;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cb_Position;
        private System.Windows.Forms.ComboBox cb_gender;
    }
}