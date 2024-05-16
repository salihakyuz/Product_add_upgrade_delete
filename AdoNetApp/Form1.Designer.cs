namespace AdoNetApp
{
    partial class Form1
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.txtUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblStocAmountUpdate = new System.Windows.Forms.Label();
            this.txtStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(665, 170);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(6, 63);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(74, 13);
            this.lblStockAmount.TabIndex = 2;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 94);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Location = new System.Drawing.Point(86, 60);
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(147, 20);
            this.txtStockAmount.TabIndex = 5;
            this.txtStockAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(86, 91);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(147, 20);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.lblStockAmount);
            this.groupBox1.Controls.Add(this.txtStockAmount);
            this.groupBox1.Controls.Add(this.lblUnitPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 160);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a New Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(86, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 21);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.txtNameUpdate);
            this.gbxUpdate.Controls.Add(this.txtUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblStocAmountUpdate);
            this.gbxUpdate.Controls.Add(this.txtStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(278, 212);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(260, 160);
            this.gbxUpdate.TabIndex = 10;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a New Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(86, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 21);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(6, 30);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(86, 27);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(147, 20);
            this.txtNameUpdate.TabIndex = 4;
            // 
            // txtUnitPriceUpdate
            // 
            this.txtUnitPriceUpdate.Location = new System.Drawing.Point(86, 91);
            this.txtUnitPriceUpdate.Name = "txtUnitPriceUpdate";
            this.txtUnitPriceUpdate.Size = new System.Drawing.Size(147, 20);
            this.txtUnitPriceUpdate.TabIndex = 6;
            // 
            // lblStocAmountUpdate
            // 
            this.lblStocAmountUpdate.AutoSize = true;
            this.lblStocAmountUpdate.Location = new System.Drawing.Point(6, 63);
            this.lblStocAmountUpdate.Name = "lblStocAmountUpdate";
            this.lblStocAmountUpdate.Size = new System.Drawing.Size(74, 13);
            this.lblStocAmountUpdate.TabIndex = 2;
            this.lblStocAmountUpdate.Text = "Stock Amount";
            // 
            // txtStockAmountUpdate
            // 
            this.txtStockAmountUpdate.Location = new System.Drawing.Point(86, 60);
            this.txtStockAmountUpdate.Name = "txtStockAmountUpdate";
            this.txtStockAmountUpdate.Size = new System.Drawing.Size(147, 20);
            this.txtStockAmountUpdate.TabIndex = 5;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(6, 94);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPriceUpdate.TabIndex = 3;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(562, 212);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 22);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 384);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.TextBox txtUnitPriceUpdate;
        private System.Windows.Forms.Label lblStocAmountUpdate;
        private System.Windows.Forms.TextBox txtStockAmountUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

