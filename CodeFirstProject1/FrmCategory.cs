using CodeFirstProject1.DAL.Context;
using CodeFirstProject1.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstProject1
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        MovieContext Context = new MovieContext();

        void listele()
        {
            var value = Context.Categories.ToList();
            VeriTablosu.DataSource = value;
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            Category ekle = new Category();
            ekle.CategoryName = txtkategoriad.Text;
            Context.Categories.Add(ekle);
            Context.SaveChanges();
            listele();
            MessageBox.Show("Yeni Kategori Başarılı Bir Şekilde Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtkategoriid.Text);
            var deger = Context.Categories.Find(id);
            deger.CategoryName = (txtkategoriad.Text);
            Context.SaveChanges();
            listele();
            MessageBox.Show("Yeni Kayıt Başarılı Bir Şekilde Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtkategoriid.Text);
            var deger = Context.Categories.Find(id);
            Context.Categories.Remove(deger);
            Context.SaveChanges();
            listele();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silinmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            var deger = Context.Categories.Where(x=>x.CategoryName.Contains(txtkategoriad.Text)).ToList();
            VeriTablosu.DataSource= deger;
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
