using Dapper;
using DapperProject.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperProject
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=Northwind;Integrated Security=True");
        private async void btncategorylist_Click(object sender, EventArgs e)
        {
            string Query = "Select * From Categories";
            var Values = await connection.QueryAsync<ResultCategoryDto>(Query);
            dataGridView1.DataSource = Values;
        }

        private async void btncreatecategory_Click(object sender, EventArgs e)
        {
            string Query = "Insert Into Categories(CategoryName,Description) Values (@p1,@p2) ";
            var Parameters = new DynamicParameters();
            Parameters.Add("@p1", TxtCategoryID.Text);
            Parameters.Add("@p2", TxtCategoryName.Text);
            await connection.ExecuteAsync(Query, Parameters);
        }

        private async void btncategoryupdate_Click(object sender, EventArgs e)
        {
            string Query = "Update Categories Set CategoryName=@p1,Description=@p2 Where CategoryID=@p3";
            var Parameters = new DynamicParameters();
            Parameters.Add("@p1", TxtCategoryName.Text);
            Parameters.Add("@p2", TxtCategoryDescription.Text);
            Parameters.Add("@p3", TxtCategoryID.Text);
            await connection.ExecuteAsync(Query, Parameters);
        }

        private async void btncategorydelete_Click(object sender, EventArgs e)
        {
            string Query = "Delete From Categories Where CategoryID=@p1";
            var paramaters = new DynamicParameters();
            paramaters.Add("@p1", TxtCategoryID.Text);
            await connection.ExecuteAsync(Query, paramaters);
        }

        private async void FrmCategories_Load(object sender, EventArgs e)
        {
            //Kategori Sayısı
            string Query = "Select Count(*) From Categories";
            var Values = await connection.ExecuteScalarAsync<int>(Query);
            LblCategoryCount.Text = "Category Count : " + Values;

            //Ürün Sayısı
            string Query2 = "Select Count(*) From Products";
            var Values2 = await connection.ExecuteScalarAsync<int?>(Query2);
            LblProductCount.Text = "Product Count : " + Values2;

            //Ortalama Ürün Stok Sayısı
            string Query3 = "Select AVG(UnitsInStock) From Products";
            var Values3 = await connection.ExecuteScalarAsync<decimal>(Query3);
            LblAvarageProductStockCount.Text = "Avarage Product Stocks Count : " + Values3;

            //Deniz Ürünleri Kategorisinde Olan Ürünlerin Toplam Fiyatı
            string Query4 = "Select SUM(UnitPrice) From Products Where CategoryID = (Select CategoryID From Categories Where CategoryName = 'Seafood')";
            var Values4 = await connection.ExecuteScalarAsync<decimal?>(Query4);
            LblSeaFoodProductTotalPrice.Text = "Seafood Products Total Price : " + Values4;
        }
    }
}
