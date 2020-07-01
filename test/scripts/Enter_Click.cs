using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace test.scripts
{
    class Enter_Click
    {
        static public DataGridView LCD;

       static public void Entering ()
        {
            string old = Form1.tabl;
            int select = LCD.CurrentCell.RowIndex;
            string name = LCD.Rows[select].Cells[0].Value.ToString();
             string Count = LCD.Rows[select].Cells[2].Value.ToString();
            string place = LCD.Rows[select].Cells[3].Value.ToString();
            if (place == "Склад")
                Form1.tabl = "All_warehouse";
             if (place=="Магазин")
                Form1.tabl = "Shop";
            string sql = "UPDATE "+Form1.tabl+" SET Action=True WHERE Name LIKE '"+name+"' AND Value LIKE'"+Count+"'";
            if(Count != "" && name != "")
            {
                using (MySqlConnection connection = new MySqlConnection(Form1.connection))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                Form1.tabl = old;
                loadMain.Load();
            }
            else
            {
                MessageBox.Show("Вы выбрали пустое поле");
            }
           
        }
    }
}
