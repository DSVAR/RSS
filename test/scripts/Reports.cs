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
        static public bool ter = false;
        static public DataGridView LCD;
        static public DataGridView LCD1;
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


  
        static public void RPAll_warehouse()
        {
            string SQL = "SELECT  Name, Company, Value, Place, Action FROM "+Reporting.namesBD+" WHERE Action="+ter+"";
            dt.Clear();
            using (MySqlConnection connection = new MySqlConnection(Form1.connection))
            {
                connection.Open();

                MySqlDataAdapter adapt = new MySqlDataAdapter(SQL, connection);
                adapt.Fill(dt);
                connection.Close();
            }

            LCD1.DataSource = dt;
        }
    }
}
