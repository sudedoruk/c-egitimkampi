using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD=Create-Read-Update-Delete
            Console.WriteLine("***** MENÜ SİPARİŞ PANELİ *****");
            Console.WriteLine();

            Console.WriteLine("---------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();
            ////veritabanına bağlanıyo
            //MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=EgitimKampi;Uid=root;Pwd=1013;");
            //connection.Open();

            //MySqlCommand command = new MySqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();//sorguyu koşulsuz çalıştır.

            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");

            #endregion
            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            //Console.Write("Ürün Durumu(True/False): ");
            //string productstatus = Console.ReadLine();
            //MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=EgitimKampi;Uid=root;Pwd=1013;");
            //connection.Open();
            //MySqlCommand command = new MySqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", productstatus);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Başarıyla Eklendi");
            #endregion
            #region Ürün Listeleme İşi

            //MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=EgitimKampi;Uid=root;Pwd=1013;");
            //connection.Open();

            //MySqlCommand command = new MySqlCommand("Select * From TblProduct", connection);
            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            //Console.ReadLine();
            #endregion
            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=EgitimKampi;Uid=root;Pwd=1013;");
            //connection.Open();

            //MySqlCommand command = new MySqlCommand("Delete from TblProduct Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi tamamlandı");
            //Console.ReadLine();

            #endregion
            #region Ürün Güncelleme İşlemi
            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=EgitimKampi;Uid=root;Pwd=1013;");
            //connection.Open();
            //MySqlCommand command = new MySqlCommand("Update TblProduct set ProductName = @productName,ProductPrice=@productPrice where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();


            //connection.Close();
            //Console.WriteLine("Güncelleme İşlemi Başarılı");
            //Console.ReadLine();
            #endregion
        }
    }
}
