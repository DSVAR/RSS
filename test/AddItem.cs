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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();

            Add_Items.Company = textBox2;
            Add_Items.Name = textBox1;
            Add_Items.Value = textBox3;
            Add_Items.Place = comboBox1;
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Items.add();
            loadMain.Load();
        }
    }
}
