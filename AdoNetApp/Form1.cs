using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = txtName.Text,
                StockAmount = Convert.ToInt32(txtStockAmount.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
            });
            LoadProducts();
            MessageBox.Show("Product Succesfully Added!");
        }



        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)//hangi eleman seçildiyse ilgili elemana onu ata
        {
            txtNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();//dgwproductsın seçili olan rowunun seçili olan hücrelerinden birinci değeri string çevir
            txtStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),//ıd de bir değişiklik olmadığı için bu şekilde durmalı
                Name = txtNameUpdate.Text,
                StockAmount = Convert.ToInt32(txtStockAmountUpdate.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPriceUpdate.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Product Updated!");

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(Id);
            LoadProducts();
            MessageBox.Show("Product Deleted!");
        }


    }
}
