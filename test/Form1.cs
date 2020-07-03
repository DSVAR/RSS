using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using test.scripts;
using System.Windows.Input;

namespace test
{
    public partial class Form1 : Form
    {

        static public string connection = @"server=server197.hosting.reg.ru; user=u1027450_tester; database=u1027450_test_rss;password=kawabanga1; charset=utf8";
    //    public static System.Windows.Forms.MouseButtons MouseButtons { get; }


        static public string tabl;
        public Form1()
        {
            InitializeComponent();

            loadMain.LCDl = dataGridView1;

            Enter_Click.LCD = dataGridView1;
            Sell.LCD = dataGridView1;
            Insert_Item.LCD = dataGridView1;

            ToolStripMenuItem enter = new ToolStripMenuItem("принять");
            ToolStripMenuItem sell = new ToolStripMenuItem("продать");
            contextMenuStrip1.Items.AddRange(new[] { enter, sell });

            dataGridView1.ContextMenuStrip = contextMenuStrip1;

            enter.Click += Enter_click;
            sell.Click += Sells;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabl = "All_warehouse";
            loadMain.Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            loadMain.Load();
            radioButton1.Checked=true;
            tabl = "All";
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form add = new AddItem();
            add.Show();
        }

    

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
  
        }


        void Enter_click(object sender, EventArgs e)
        {
            Enter_Click.Entering();
        }

        void Sells(object sender, EventArgs e)
        {
            
                int select = dataGridView1.CurrentCell.RowIndex;
                string Bo = dataGridView1.Rows[select].Cells[4].Value.ToString();
                if (Bo == "True")
                {
                    Sell.dyb();
                }
                else
                {
                    MessageBox.Show("Нельзя продать товара который не принят");
                }
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabl = "All";
            loadMain.Load();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tabl = "Shop";
            loadMain.Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert_Item.Items();
            loadMain.Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form report = new Reporting();
            report.Show();
        }
    }
}
