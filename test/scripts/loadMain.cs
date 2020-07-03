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
    class loadMain
    {
        static public DataTable dt = new DataTable { TableName = "Ware" };

        static public DataGridView LCDl;
        static public void Load()
        {
            if (Form1.tabl == "All") { 
                string sql = "SELECT Name, Company, Value, Place, Action FROM All_warehouse";
                string sql1 = "SELECT Name, Company, Value, Place, Action FROM Shop";
                string sales = "SELECT Name, Company, Value, Place FROM Sales";
                using (MySqlConnection connection= new MySqlConnection(Form1.connection))
                {
                    connection.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql,connection);
                    dt.Clear();

                    adapter.Fill(dt);

                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(sql1, connection);

                    adapter1.Fill(dt);

                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(sales, connection);
                    adapter2.Fill(dt);

                    connection.Close();

                }
            }


            if(Form1.tabl == "All_warehouse")
            {
                string sql = "SELECT Name, Company, Value, Place, Action FROM All_warehouse";
                using (MySqlConnection connection = new MySqlConnection(Form1.connection))
                {
                    connection.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                    dt.Clear();

                    adapter.Fill(dt);


                    connection.Close();

                }
            }


            if (Form1.tabl == "Shop")
            {
                string sql1 = "SELECT Name, Company, Value, Place, Action FROM Shop";
                using (MySqlConnection connection1 = new MySqlConnection(Form1.connection))
                {
                    connection1.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql1, connection1);
                    dt.Clear();

                    adapter.Fill(dt);


                    connection1.Close();

                }
            }
            LCDl.Invoke((MethodInvoker)(() => LCDl.DataSource = dt));
            if (LCDl.Rows.Count == 1)
                LCDl.ReadOnly = true;
            else
                LCDl.ReadOnly = false;
        }


    }
}
