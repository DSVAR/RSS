using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace test
{
    class Sales_Items
    {
        static public ComboBox CB,CB1;
        static public Label lab;

        static public DataTable dtC=new DataTable();
        static public DataTable DC = new DataTable();
        static public DataTable DCS = new DataTable();
        static public void Combo1()
        {
            dtC.Clear();
           
            string sql = "Select Name FROM Shop WHERE Value > '0'";
            using(MySqlConnection connection = new MySqlConnection(Form1.connection))
            {
              
                connection.Open();
                MySqlDataAdapter adap = new MySqlDataAdapter(sql, connection);

                adap.Fill(dtC);
                connection.Close();

            }
         
            CB.DataSource = dtC;
            CB.DisplayMember = "Name";
            CB.ValueMember = "Name";



        }

        static public void Combo2()
        {
            string sql = "SELECT Company FROM Shop WHERE Name LIKE'"+CB.Text+"'";
            DC.Clear();
            using(MySqlConnection connection=new MySqlConnection(Form1.connection))
            {

                connection.Open();
                MySqlDataAdapter adap = new MySqlDataAdapter(sql, connection);

                adap.Fill(DC);
                connection.Close();

            }
            CB1.DataSource = DC;
            CB1.DisplayMember = "Company";
            CB1.ValueMember = "Company";
        }

        static public void labs()
        {
            string sql = "SELECT Value FROM Shop WHERE Name LIKE'" + CB.Text + "' AND Company LIKE '"+CB1.Text+"'";
           
            using (MySqlConnection connection = new MySqlConnection(Form1.connection))
            {

                connection.Open();
                MySqlDataAdapter adap = new MySqlDataAdapter(sql, connection);

                adap.Fill(DCS);
                connection.Close();

            }
            lab.Invoke((MethodInvoker)(() => lab.Text = DCS.Rows[0][0].ToString()));
        }

    }
}
