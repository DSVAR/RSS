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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            Sales_Items.CB = comboBox1;
            Sales_Items.CB1 = comboBox2;
            Sales_Items.lab =label6;

            End_sale.Company = comboBox2;
            End_sale.NameS = comboBox1;
            End_sale.las = label6;
            End_sale.nameP = textBox1;
            End_sale.Value = textBox2;

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
            comboBox2.DisplayMember = "Company";
            comboBox2.ValueMember = "Company";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         Sales_Items.labs();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            Sales_Items.Combo1();
            //Sales_Items.Combo2();
            //Sales_Items.labs();


    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int la = Convert.ToInt32(label6.Text);
            if (textBox1.Text == null || textBox2.Text==null)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if(la>0)
                End_sale.end();
                
                Sell.sale.Close();
                loadMain.Load();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sales_Items.Combo2();
        }

       
        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            //Sales_Items.labs();
        }
    }
}
