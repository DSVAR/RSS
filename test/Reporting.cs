using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.scripts;

namespace test
{
    public partial class Reporting : Form
    {
        static public DataTable dt;
        static public string namesBD = "Shop";

        public Reporting()
        {
            InitializeComponent();
            Reports.LCD = dataGridView1;
            Reports.LCD1 = dataGridView2;

            easy_Save.dg = dataGridView1;
            easy_Save.dg1 = dataGridView2;
            easy_Save.rd = radioButton1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = false;
            radioButton7.Checked = true;
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            Reports.RPSale();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);

            else
                dataGridView2.Sort(dataGridView2.Columns[2], ListSortDirection.Ascending);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);

            else
                dataGridView2.Sort(dataGridView2.Columns[2], ListSortDirection.Descending);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            namesBD = "All_warehouse";
            panel2.Visible = true;
            panel4.Visible = true;
            Reports.RPAll_warehouse();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            namesBD = "Shop";
            panel2.Visible = true;
            panel4.Visible = true;
            Reports.RPAll_warehouse();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Reports.ter = true;
            Reports.RPAll_warehouse();

        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            Reports.ter = false;
            Reports.RPAll_warehouse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            easy_Save.saving();
        }
    }
}
