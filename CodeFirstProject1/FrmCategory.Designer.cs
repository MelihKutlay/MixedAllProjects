namespace CodeFirstProject1
{
    partial class FrmCategory
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
            this.btnlistele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkategoriid = new System.Windows.Forms.TextBox();
            this.VeriTablosu = new System.Windows.Forms.DataGridView();
            this.txtkategoriad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VeriTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(352, 1);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(120, 28);
            this.btnlistele.TabIndex = 0;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori İd :";
            // 
            // txtkategoriid
            // 
            this.txtkategoriid.Location = new System.Drawing.Point(95, 6);
            this.txtkategoriid.Name = "txtkategoriid";
            this.txtkategoriid.Size = new System.Drawing.Size(251, 22);
            this.txtkategoriid.TabIndex = 2;
            // 
            // VeriTablosu
            // 
            this.VeriTablosu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VeriTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VeriTablosu.Location = new System.Drawing.Point(15, 116);
            this.VeriTablosu.Name = "VeriTablosu";
            this.VeriTablosu.RowHeadersWidth = 51;
            this.VeriTablosu.RowTemplate.Height = 24;
            this.VeriTablosu.Size = new System.Drawing.Size(773, 322);
            this.VeriTablosu.TabIndex = 3;
            // 
            // txtkategoriad
            // 
            this.txtkategoriad.Location = new System.Drawing.Point(95, 34);
            this.txtkategoriad.Name = "txtkategoriad";
            this.txtkategoriad.Size = new System.Drawing.Size(251, 22);
            this.txtkategoriad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori Ad :";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(352, 60);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(120, 30);
            this.btnguncelle.TabIndex = 6;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(352, 30);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(120, 28);
            this.btnekle.TabIndex = 7;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(108, 62);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(116, 30);
            this.btnara.TabIndex = 8;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(230, 60);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(116, 30);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtkategoriad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VeriTablosu);
            this.Controls.Add(this.txtkategoriid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlistele);
            this.Name = "FrmCategory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeriTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkategoriid;
        private System.Windows.Forms.DataGridView VeriTablosu;
        private System.Windows.Forms.TextBox txtkategoriad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnsil;
    }
}

