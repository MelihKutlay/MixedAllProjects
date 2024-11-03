namespace CodeFirstProject1
{
    partial class FrmMovie
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
            this.btnsil = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txtfilmad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VeriTablosu = new System.Windows.Forms.DataGridView();
            this.txtfilmid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.txtacıklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfilmsuresi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.btnkategorivefilmlistele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VeriTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(364, 72);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(120, 30);
            this.btnsil.TabIndex = 19;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(364, 142);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(120, 30);
            this.btnara.TabIndex = 18;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(364, 39);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(120, 28);
            this.btnekle.TabIndex = 17;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(364, 108);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(120, 30);
            this.btnguncelle.TabIndex = 16;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txtfilmad
            // 
            this.txtfilmad.Location = new System.Drawing.Point(107, 38);
            this.txtfilmad.Name = "txtfilmad";
            this.txtfilmad.Size = new System.Drawing.Size(251, 22);
            this.txtfilmad.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Film Ad :";
            // 
            // VeriTablosu
            // 
            this.VeriTablosu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VeriTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VeriTablosu.Location = new System.Drawing.Point(12, 178);
            this.VeriTablosu.Name = "VeriTablosu";
            this.VeriTablosu.RowHeadersWidth = 51;
            this.VeriTablosu.RowTemplate.Height = 24;
            this.VeriTablosu.Size = new System.Drawing.Size(773, 352);
            this.VeriTablosu.TabIndex = 13;
            // 
            // txtfilmid
            // 
            this.txtfilmid.Location = new System.Drawing.Point(107, 10);
            this.txtfilmid.Name = "txtfilmid";
            this.txtfilmid.Size = new System.Drawing.Size(251, 22);
            this.txtfilmid.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Film İd :";
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(364, 10);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(120, 28);
            this.btnlistele.TabIndex = 10;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // txtacıklama
            // 
            this.txtacıklama.Location = new System.Drawing.Point(107, 92);
            this.txtacıklama.Name = "txtacıklama";
            this.txtacıklama.Size = new System.Drawing.Size(251, 22);
            this.txtacıklama.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "İzlenme Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Film Süresi :";
            // 
            // txtfilmsuresi
            // 
            this.txtfilmsuresi.Location = new System.Drawing.Point(107, 66);
            this.txtfilmsuresi.Name = "txtfilmsuresi";
            this.txtfilmsuresi.Size = new System.Drawing.Size(251, 22);
            this.txtfilmsuresi.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kategori :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Açıklama";
            // 
            // cmbkategori
            // 
            this.cmbkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(107, 148);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(251, 24);
            this.cmbkategori.TabIndex = 32;
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(107, 120);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(251, 22);
            this.msktarih.TabIndex = 33;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // btnkategorivefilmlistele
            // 
            this.btnkategorivefilmlistele.Location = new System.Drawing.Point(501, 72);
            this.btnkategorivefilmlistele.Name = "btnkategorivefilmlistele";
            this.btnkategorivefilmlistele.Size = new System.Drawing.Size(224, 30);
            this.btnkategorivefilmlistele.TabIndex = 34;
            this.btnkategorivefilmlistele.Text = "Kategori ve Filmleri Listele";
            this.btnkategorivefilmlistele.UseVisualStyleBackColor = true;
            this.btnkategorivefilmlistele.Click += new System.EventHandler(this.btnkategorivefilmlistele_Click);
            // 
            // FrmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 542);
            this.Controls.Add(this.btnkategorivefilmlistele);
            this.Controls.Add(this.msktarih);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.txtfilmsuresi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtacıklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtfilmad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VeriTablosu);
            this.Controls.Add(this.txtfilmid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlistele);
            this.Name = "FrmMovie";
            this.Text = "FrmMovie";
            this.Load += new System.EventHandler(this.FrmMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeriTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtfilmad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView VeriTablosu;
        private System.Windows.Forms.TextBox txtfilmid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.TextBox txtacıklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfilmsuresi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.Button btnkategorivefilmlistele;
    }
}