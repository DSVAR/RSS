using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace test
{
    class Sales_Items
    {
        static public ComboBox CB,CB1;
        static public Label lab;

        static public void Combo1()
        {
            DataTable dtC = new DataTable();

            dtC.Clear();
           
            string sql = "Select Name FROM Shop WHERE Value > '0'";
            using(MySqlConnection connection = new MySqlConnection(Form1.connection))
            {
              
                connection.Open();
                MySqlDataAdapter adap = new MySqlDataAdapter(sql, connection);

                adap.Fill(dtC);
                CB.DataSource = dtC;
                CB.DisplayMember = "Name";
                CB.ValueMember = "Name";
                connection.Close();

            }
         
         



        }

        static public void Combo2()
        {
            DataTable DC = new DataTable();

            string sql = "SELECT Company FROM Shop WHERE Name LIKE'"+CB.Text+"'";
            DC.Clear();
            using(MySqlConnection connectionC=new MySqlConnection(Form1.connection))
            {

                connectionC.Open();
                MySqlDataAdapter adap1 = new MySqlDataAdapter(sql, connectionC);

                adap1.Fill(DC);
                CB1.Invoke((MethodInvoker)(() => CB1.DataSource = DC));
                CB1.Invoke((MethodInvoker)(() => CB1.DisplayMember = "Company"));
                CB1.Invoke((MethodInvoker)(() => CB1.ValueMember = "Company"));
                connectionC.Close();

            }
           
        }

        static public void labs()
        {
            DataTable DCS = new DataTable();
            string sql = "SELECT Value FROM Shop WHERE Name LIKE'" + CB.Text + "' AND Company LIKE '"+CB1.Text+"'";
            DCS.Clear();
            using (MySqlConnection connection = new MySqlConnection(Form1.connection))
            {

                connection.Open();
                MySqlDataAdapter adap = new MySqlDataAdapter(sql, connection);

                adap.Fill(DCS);

                lab.Invoke((MethodInvoker)(() => lab.Text = DCS.Rows[0][0].ToString()));
                connection.Close();

            }
           
        }

    }
}
