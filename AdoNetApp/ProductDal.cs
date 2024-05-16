using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetApp
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=ETradeVersion1; integrated security=true ");

        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader=command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product 
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;


        }
        public void Add(Product product) //yeni ürün ekleme
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@Name,@StockAmount,@UnitPrice)",_connection);
            command.Parameters.AddWithValue("Name", product.Name);
            command.Parameters.AddWithValue("StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("UnitPrice", product.UnitPrice);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void Update(Product product) //yeni ürün ekleme
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name=@Name,StockAmount=@StockAmount, UnitPrice=UnitPrice where Id=@Id", _connection); //where komutu yazmadan güncellenmesi durumunda bütün kayıtlar bozulur
            command.Parameters.AddWithValue("Name", product.Name);
            command.Parameters.AddWithValue("StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@Id",product.Id);
            command.ExecuteNonQuery();
            _connection.Close();

        }

        public void Delete(int id) //ürün silme. Silme işlemi id üzerinden gidilecek. Yukardaki metod kopyalanarak yapıldı fakat bir tek id kullanılacağı için diğerleri silindi
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete From Products where Id=@Id", _connection); //where komutu yazmadan güncellenmesi durumunda bütün kayıtlar bozulur
            command.Parameters.AddWithValue("@Id",id);
            command.ExecuteNonQuery();
            _connection.Close();

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
