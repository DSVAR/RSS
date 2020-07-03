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
        public Reporting()
        {
            InitializeComponent();
            Reports.LCD = dataGridView1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            Reports.RPSale();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
        }
    }
}
