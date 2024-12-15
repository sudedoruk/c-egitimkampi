using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // MySQL kütüphanesi

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.WriteLine("****** C# veri tabanlı ürün-kategori bilgi sistemi*****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-çıkış yap");
            Console.Write("getirmek istediğiniz tablo numarasını giriniz: ");
            string tableNumber=Console.ReadLine();
            Console.WriteLine("--------------------------------------");
            //veritabanına bağlanıyo 
            MySqlConnection connection=new MySqlConnection("Server=localhost;Port=3306;Database=EgitimKampi;Uid=root;Pwd=1013;");
            connection.Open();

            MySqlCommand command = new MySqlCommand("Select * From TblCategory", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            connection.Close();
            //verileri yazdırıyo ne yazsam listeliycek.1,2,3e bağlamadım yani
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }



            Console.Read();



        }
    }
}
