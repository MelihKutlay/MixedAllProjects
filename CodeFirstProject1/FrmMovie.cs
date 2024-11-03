using CodeFirstProject1.DAL.Context;
using CodeFirstProject1.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstProject1
{
    public partial class FrmMovie : Form
    {
        public FrmMovie()
        {
            InitializeComponent();
        }
        MovieContext db = new MovieContext();
        private void FrmMovie_Load(object sender, EventArgs e)
        {
            var list = db.Categories.ToList();
            cmbkategori.DisplayMember = "CategoryName";
            cmbkategori.ValueMember = "CategoryID";
            cmbkategori.DataSource = list;
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var listele = db.Movies.ToList();
            VeriTablosu.DataSource = listele;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            Movie ekle = new Movie();
            ekle.MovieTitle = txtfilmad.Text;
            ekle.MovieDuration = int.Parse(txtfilmsuresi.Text);
            ekle.MovieDescription = txtacıklama.Text;
            ekle.MovieCreateDateTime = DateTime.Parse(msktarih.Text);
            ekle.CategoryID = int.Parse(cmbkategori.SelectedValue.ToString());
            db.Movies.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Yeni Film Başarılı Bir Şekilde Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtfilmid.Text);
            var value = db.Movies.Find(id);
            db.Movies.Remove(value);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtfilmid.Text);
            var values = db.Movies.Find(id);
            values.MovieTitle = txtfilmad.Text;
            values.MovieDuration = int.Parse(txtfilmsuresi.Text);
            values.MovieDescription = txtacıklama.Text;
            values.MovieCreateDateTime = DateTime.Parse(msktarih.Text);
            values.CategoryID = int.Parse(cmbkategori.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Yeni Kayıt Başarılı Bir Şekilde Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            var value = db.Movies.Where(x => x.MovieTitle.Contains(txtfilmad.Text)).ToList();
            VeriTablosu.DataSource = value;
        }

        private void btnkategorivefilmlistele_Click(object sender, EventArgs e)
        {
            var value = db.Movies.Join(db.Categories, movie => movie.CategoryID, category => category.CategoryID, (movie, category) => new
            {
                MovieId = movie.MovieID,
                MovieTitle = movie.MovieTitle,
                MovieDescription = movie.MovieDescription,
                MovieCreateDateTime = movie.MovieCreateDateTime,
                CategoryName = category.CategoryName,

            }).ToList();
            VeriTablosu.DataSource = value;
        }
    }
}
