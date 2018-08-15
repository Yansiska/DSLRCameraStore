namespace DSLR_CameraStore
{
    partial class DetailProduct
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
            this.dgDetailProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdProductP = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtPriceP = new System.Windows.Forms.TextBox();
            this.lblIdProduct = new System.Windows.Forms.Label();
            this.txtStockP = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtNameP = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescriptionP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnUpdateP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetailProduct
            // 
            this.dgDetailProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailProduct.Location = new System.Drawing.Point(273, 7);
            this.dgDetailProduct.Name = "dgDetailProduct";
            this.dgDetailProduct.Size = new System.Drawing.Size(543, 212);
            this.dgDetailProduct.TabIndex = 47;
            this.dgDetailProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailProduct_CellClick);
            this.dgDetailProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailProduct_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID_Product";
            // 
            // txtIdProductP
            // 
            this.txtIdProductP.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProductP.Location = new System.Drawing.Point(112, 12);
            this.txtIdProductP.Name = "txtIdProductP";
            this.txtIdProductP.Size = new System.Drawing.Size(144, 25);
            this.txtIdProductP.TabIndex = 44;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(20, 193);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(65, 18);
            this.lblQty.TabIndex = 38;
            this.lblQty.Text = "Description";
            // 
            // txtPriceP
            // 
            this.txtPriceP.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceP.Location = new System.Drawing.Point(112, 144);
            this.txtPriceP.Name = "txtPriceP";
            this.txtPriceP.Size = new System.Drawing.Size(141, 25);
            this.txtPriceP.TabIndex = 37;
            // 
            // lblIdProduct
            // 
            this.lblIdProduct.AutoSize = true;
            this.lblIdProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblIdProduct.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduct.Location = new System.Drawing.Point(20, 147);
            this.lblIdProduct.Name = "lblIdProduct";
            this.lblIdProduct.Size = new System.Drawing.Size(35, 18);
            this.lblIdProduct.TabIndex = 36;
            this.lblIdProduct.Text = "Price";
            // 
            // txtStockP
            // 
            this.txtStockP.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockP.Location = new System.Drawing.Point(112, 98);
            this.txtStockP.Name = "txtStockP";
            this.txtStockP.Size = new System.Drawing.Size(141, 25);
            this.txtStockP.TabIndex = 35;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(20, 101);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(36, 18);
            this.lblAddress.TabIndex = 34;
            this.lblAddress.Text = "Stock";
            // 
            // txtNameP
            // 
            this.txtNameP.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameP.Location = new System.Drawing.Point(112, 54);
            this.txtNameP.Name = "txtNameP";
            this.txtNameP.Size = new System.Drawing.Size(141, 25);
            this.txtNameP.TabIndex = 33;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 18);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name_Product";
            // 
            // txtDescriptionP
            // 
            this.txtDescriptionP.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionP.Location = new System.Drawing.Point(112, 190);
            this.txtDescriptionP.Multiline = true;
            this.txtDescriptionP.Name = "txtDescriptionP";
            this.txtDescriptionP.Size = new System.Drawing.Size(141, 72);
            this.txtDescriptionP.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(150)))), ((int)(((byte)(32)))));
            this.button1.BackgroundImage = global::DSLR_CameraStore.Properties.Resources.back_Product_list;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-1, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 50);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.BackColor = System.Drawing.Color.White;
            this.btnDeleteP.BackgroundImage = global::DSLR_CameraStore.Properties.Resources.delete;
            this.btnDeleteP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteP.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteP.Location = new System.Drawing.Point(184, 281);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(49, 50);
            this.btnDeleteP.TabIndex = 46;
            this.btnDeleteP.UseVisualStyleBackColor = false;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // btnUpdateP
            // 
            this.btnUpdateP.BackColor = System.Drawing.Color.White;
            this.btnUpdateP.BackgroundImage = global::DSLR_CameraStore.Properties.Resources.diskette;
            this.btnUpdateP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateP.Font = new System.Drawing.Font("Agency FB", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateP.Location = new System.Drawing.Point(132, 281);
            this.btnUpdateP.Name = "btnUpdateP";
            this.btnUpdateP.Size = new System.Drawing.Size(51, 50);
            this.btnUpdateP.TabIndex = 43;
            this.btnUpdateP.UseVisualStyleBackColor = false;
            this.btnUpdateP.Click += new System.EventHandler(this.btnUpdateP_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.BackColor = System.Drawing.Color.White;
            this.btnAddP.BackgroundImage = global::DSLR_CameraStore.Properties.Resources.Save_Button;
            this.btnAddP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddP.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddP.Location = new System.Drawing.Point(85, 281);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(46, 50);
            this.btnAddP.TabIndex = 42;
            this.btnAddP.UseVisualStyleBackColor = false;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // DetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DSLR_CameraStore.Properties.Resources.Product_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescriptionP);
            this.Controls.Add(this.dgDetailProduct);
            this.Controls.Add(this.btnDeleteP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdProductP);
            this.Controls.Add(this.btnUpdateP);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtPriceP);
            this.Controls.Add(this.lblIdProduct);
            this.Controls.Add(this.txtStockP);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtNameP);
            this.Controls.Add(this.lblName);
            this.Name = "DetailProduct";
            this.Text = "DetailProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DetailProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetailProduct;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProductP;
        private System.Windows.Forms.Button btnUpdateP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtPriceP;
        private System.Windows.Forms.Label lblIdProduct;
        private System.Windows.Forms.TextBox txtStockP;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtNameP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDescriptionP;
        private System.Windows.Forms.Button button1;
    }
}