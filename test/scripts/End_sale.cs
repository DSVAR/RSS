using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace test.scripts
{
    class End_sale
    {
        static public TextBox nameP,Value;
        static public ComboBox Company, NameS;
        static public Label las;
        static public string cost;
        static public void end()
        {
            string action = "Продан";
           string sql = "INSERT INTO Sales (NamePersonal, Name, Company, Value, Action) VALUES ('" + nameP.Text+"', '"+NameS.Text+"', '"+Company.Text+"', '"+Value.Text+"', '"+action+"')";
            int core = Convert.ToInt32(Value.Text);
            int qu = Convert.ToInt32(las.Text);
            int be = qu- core ;

            string upd = "UPDATE Shop SET Value='"+be+"' WHERE Name LIKE '"+NameS.Text+"' AND Company LIKE '"+Company.Text+"'";
            using (MySqlConnection connection = new MySqlConnection(Form1.connection))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();

                MySqlCommand command2 = new MySqlCommand(upd, connection);
                command2.ExecuteNonQuery();


                connection.Close();

            }
        }
    }
}
