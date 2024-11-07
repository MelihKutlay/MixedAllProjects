namespace DapperProject
{
    partial class FrmCategories
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
            this.btncategorylist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtCategoryID = new System.Windows.Forms.TextBox();
            this.TxtCategoryName = new System.Windows.Forms.TextBox();
            this.btncreatecategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCategoryDescription = new System.Windows.Forms.TextBox();
            this.btncategoryupdate = new System.Windows.Forms.Button();
            this.btncategorydelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblCategoryCount = new System.Windows.Forms.Label();
            this.LblProductCount = new System.Windows.Forms.Label();
            this.LblSeaFoodProductTotalPrice = new System.Windows.Forms.Label();
            this.LblAvarageProductStockCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncategorylist
            // 
            this.btncategorylist.Location = new System.Drawing.Point(473, 7);
            this.btncategorylist.Name = "btncategorylist";
            this.btncategorylist.Size = new System.Drawing.Size(143, 30);
            this.btncategorylist.TabIndex = 0;
            this.btncategorylist.Text = "List";
            this.btncategorylist.UseVisualStyleBackColor = true;
            this.btncategorylist.Click += new System.EventHandler(this.btncategorylist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 288);
            this.dataGridView1.TabIndex = 1;
            // 
            // TxtCategoryID
            // 
            this.TxtCategoryID.Location = new System.Drawing.Point(157, 7);
            this.TxtCategoryID.Name = "TxtCategoryID";
            this.TxtCategoryID.Size = new System.Drawing.Size(287, 22);
            this.TxtCategoryID.TabIndex = 2;
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.Location = new System.Drawing.Point(157, 41);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Size = new System.Drawing.Size(287, 22);
            this.TxtCategoryName.TabIndex = 4;
            // 
            // btncreatecategory
            // 
            this.btncreatecategory.Location = new System.Drawing.Point(473, 43);
            this.btncreatecategory.Name = "btncreatecategory";
            this.btncreatecategory.Size = new System.Drawing.Size(143, 30);
            this.btncreatecategory.TabIndex = 3;
            this.btncreatecategory.Text = "Add";
            this.btncreatecategory.UseVisualStyleBackColor = true;
            this.btncreatecategory.Click += new System.EventHandler(this.btncreatecategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Category Description :";
            // 
            // TxtCategoryDescription
            // 
            this.TxtCategoryDescription.Location = new System.Drawing.Point(157, 75);
            this.TxtCategoryDescription.Multiline = true;
            this.TxtCategoryDescription.Name = "TxtCategoryDescription";
            this.TxtCategoryDescription.Size = new System.Drawing.Size(287, 69);
            this.TxtCategoryDescription.TabIndex = 8;
            // 
            // btncategoryupdate
            // 
            this.btncategoryupdate.Location = new System.Drawing.Point(473, 79);
            this.btncategoryupdate.Name = "btncategoryupdate";
            this.btncategoryupdate.Size = new System.Drawing.Size(143, 30);
            this.btncategoryupdate.TabIndex = 11;
            this.btncategoryupdate.Text = "Update";
            this.btncategoryupdate.UseVisualStyleBackColor = true;
            this.btncategoryupdate.Click += new System.EventHandler(this.btncategoryupdate_Click);
            // 
            // btncategorydelete
            // 
            this.btncategorydelete.Location = new System.Drawing.Point(473, 115);
            this.btncategorydelete.Name = "btncategorydelete";
            this.btncategorydelete.Size = new System.Drawing.Size(143, 30);
            this.btncategorydelete.TabIndex = 10;
            this.btncategorydelete.Text = "Delete";
            this.btncategorydelete.UseVisualStyleBackColor = true;
            this.btncategorydelete.Click += new System.EventHandler(this.btncategorydelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.LblSeaFoodProductTotalPrice);
            this.groupBox1.Controls.Add(this.LblAvarageProductStockCount);
            this.groupBox1.Controls.Add(this.LblProductCount);
            this.groupBox1.Controls.Add(this.LblCategoryCount);
            this.groupBox1.Location = new System.Drawing.Point(622, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 132);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories Dapper Statistics";
            // 
            // LblCategoryCount
            // 
            this.LblCategoryCount.AutoSize = true;
            this.LblCategoryCount.Location = new System.Drawing.Point(15, 31);
            this.LblCategoryCount.Name = "LblCategoryCount";
            this.LblCategoryCount.Size = new System.Drawing.Size(44, 16);
            this.LblCategoryCount.TabIndex = 0;
            this.LblCategoryCount.Text = "label4";
            // 
            // LblProductCount
            // 
            this.LblProductCount.AutoSize = true;
            this.LblProductCount.Location = new System.Drawing.Point(15, 47);
            this.LblProductCount.Name = "LblProductCount";
            this.LblProductCount.Size = new System.Drawing.Size(44, 16);
            this.LblProductCount.TabIndex = 1;
            this.LblProductCount.Text = "label4";
            // 
            // LblSeaFoodProductTotalPrice
            // 
            this.LblSeaFoodProductTotalPrice.AutoSize = true;
            this.LblSeaFoodProductTotalPrice.Location = new System.Drawing.Point(15, 80);
            this.LblSeaFoodProductTotalPrice.Name = "LblSeaFoodProductTotalPrice";
            this.LblSeaFoodProductTotalPrice.Size = new System.Drawing.Size(44, 16);
            this.LblSeaFoodProductTotalPrice.TabIndex = 3;
            this.LblSeaFoodProductTotalPrice.Text = "label4";
            // 
            // LblAvarageProductStockCount
            // 
            this.LblAvarageProductStockCount.AutoSize = true;
            this.LblAvarageProductStockCount.Location = new System.Drawing.Point(15, 63);
            this.LblAvarageProductStockCount.Name = "LblAvarageProductStockCount";
            this.LblAvarageProductStockCount.Size = new System.Drawing.Size(44, 16);
            this.LblAvarageProductStockCount.TabIndex = 2;
            this.LblAvarageProductStockCount.Text = "label4";
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncategoryupdate);
            this.Controls.Add(this.btncategorydelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCategoryDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCategoryName);
            this.Controls.Add(this.btncreatecategory);
            this.Controls.Add(this.TxtCategoryID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncategorylist);
            this.Name = "FrmCategories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncategorylist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtCategoryID;
        private System.Windows.Forms.TextBox TxtCategoryName;
        private System.Windows.Forms.Button btncreatecategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCategoryDescription;
        private System.Windows.Forms.Button btncategoryupdate;
        private System.Windows.Forms.Button btncategorydelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblCategoryCount;
        private System.Windows.Forms.Label LblProductCount;
        private System.Windows.Forms.Label LblSeaFoodProductTotalPrice;
        private System.Windows.Forms.Label LblAvarageProductStockCount;
    }
}

