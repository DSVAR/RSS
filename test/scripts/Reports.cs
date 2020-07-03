using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace test.scripts
{
    class Reports
    {
        static public DataGridView LCD;
        static public DataTable dt = new DataTable();
        static public void RPSale()
        {
            string SQL = "SELECT NamePersonal, Name, Company, Value, Place FROM Sales";
            dt.Clear();
            using (MySqlConnection connection = new MySqlConnection(Form1.connection))
            {
                connection.Open();

                MySqlDataAdapter adapt = new MySqlDataAdapter(SQL, connection);
                adapt.Fill(dt);
                connection.Close();
            }

            LCD.DataSource = dt;

        }


        static public void RPFilter_C()
        {
            string SQL = "SELECT NamePersonal, Name, Company, Value, Place FROM Sales WHERE Value< 100";
            dt.Clear();
            using (MySqlConnection connection = new MySqlConnection(Form1.connection))
            {
                connection.Open();

                MySqlDataAdapter adapt = new MySqlDataAdapter(SQL, connection);
                adapt.Fill(dt);
                connection.Close();
            }

            LCD.DataSource = dt;
        }
    }
}
