using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace test.scripts
{
    class Insert_Item
    {
        static public DataGridView LCD;

        static public void Items()
        {
            int select = LCD.CurrentCell.RowIndex;
            string name = LCD.Rows[select].Cells[0].Value.ToString();
            string company= LCD.Rows[select].Cells[1].Value.ToString();
            string Value= LCD.Rows[select].Cells[2].Value.ToString();
            string place= LCD.Rows[select].Cells[3].Value.ToString();

            if (place == "Склад") { 
                string sql = "INSERT INTO `Shop`(`Name`, `Company`, `Value`, `Action`, `Place`) SELECT * FROM All_warehouse WHERE Name LIKE '"+name+"' AND Company LIKE '"+company+"' AND Value LIKE '"+Value+"' AND Place LIKE '"+place+"' ";
                string delete = "DELETE FROM All_warehouse WHERE  Name LIKE '" + name + "' AND Company LIKE '" + company + "' AND Value LIKE '" + Value + "'";
                string update = "UPDATE Shop SET Place='Магазин', Action='False'  WHERE  Name LIKE '" + name + "' AND Company LIKE '" + company + "' AND Value LIKE '" + Value + "'";
                using (MySqlConnection connection=new MySqlConnection(Form1.connection))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                using (MySqlConnection UPD = new MySqlConnection (Form1.connection))
                {
                    UPD.Open();
                    MySqlCommand command = new MySqlCommand(update, UPD);
                    command.ExecuteNonQuery();
                    UPD.Close();
                }

                using (MySqlConnection connection1 = new MySqlConnection(Form1.connection))
                {
                    connection1.Open();
                    MySqlCommand command = new MySqlCommand(delete, connection1);
                    command.ExecuteNonQuery();
                    connection1.Close();
                }
            }
        }


    }
}
