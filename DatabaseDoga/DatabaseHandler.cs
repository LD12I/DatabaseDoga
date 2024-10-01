using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DatabaseDoga
{
    public class DatabaseHandler
    {
        string serverAddress;
        string username;
        string password;
        string databaseName;
        string connectionString;
        MySqlConnection connection;

        public DatabaseHandler()
        {

            serverAddress = "localhost";
            username = "root";
            password = "";
            databaseName = "pekseg";
            connectionString = $"Server={serverAddress};Database={databaseName};User={username};Password={password}";
            connection = new MySqlConnection(connectionString);

        }


        public List<item> ReadAll()
        {
            {
                List<item> items = new List<item>();
                try
                {
                    connection.Open();
                    string query = "select * from products";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        item oneitem = new item();
                        oneitem.id = read.GetInt32(read.GetOrdinal("id"));
                        oneitem.name = read.GetString(read.GetOrdinal("name"));
                        oneitem.quantity = read.GetInt32(read.GetOrdinal("quantity"));
                        oneitem.price = read.GetInt32(read.GetOrdinal("price"));
                        items.Add(oneitem);

                    }

                    read.Close();
                    command.Dispose();
                    connection.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show("A hiba: " + e.Message);
                }
                return items;
            }
        }

        public void insertOneItem(item oneitem)
        {
            try
            {
                connection.Open();
                string query = $"insert into products (name, quantity, price) values ('{oneitem.name}',{oneitem.quantity},{oneitem.price})";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }





        }
        public void deleteOneitem(item Deleteitem)
        {
            try
            {
                connection.Open();
                string query = $"delete from products where name='{Deleteitem.name}'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }




    }
    public class item
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }

    }
}
