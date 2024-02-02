/*
using System;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=deneme;User ID=SA;Password=Password123;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO Urn (id, ad, fiyat, tarih) VALUES (@id, @ad, @fiyat, @tarih)";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            // Kullanıcının girdiği değerleri almak için:
            Console.WriteLine("Ürünün ID'sini girin:");

            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ürünün adını girin:");
            string ad = "ğlll";

            Console.WriteLine("Ürünün fiyatını girin:");
            decimal fiyat = decimal.Parse(Console.ReadLine());

            // Şimdiki tarihi almak için:
            DateTime tarih = DateTime.Now;
            command.Parameters.AddWithValue("@tarih", tarih);

            // Sorgudaki parametreleri ayarlamak için:
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ad", ad);
            command.Parameters.AddWithValue("@fiyat", fiyat);
    

            try
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Ürün eklendi!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            Console.ReadLine();
        }
    }
}
*/