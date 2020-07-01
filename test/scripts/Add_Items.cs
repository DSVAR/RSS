using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace test.scripts
{
    class Add_Items
    {
        static public TextBox Name, Company, Value;
        static public ComboBox Place;

        static public void add()
        {
            bool act = false;
            string sql = "INSERT INTO All_warehouse(Name, Company,Value,Place,Action) VALUES('"+Name.Text + "', '"+Company.Text + "', '"+Value.Text + "', '"+Place.Text+"', '"+ act+ "')";
            using (MySqlConnection connection = new MySqlConnection (Form1.connection))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql,connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            Name.Text = null;
            Company.Text = null;
            Value.Text = null;
        }



    }
}
