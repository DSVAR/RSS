using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.scripts
{
    class Sell
    {

        static public DataGridView LCD;
        static public Form sale = new Sales();
        static public void dyb()
        {
            int select = LCD.CurrentCell.RowIndex;
            string count = LCD.Rows[select].Cells[2].Value.ToString();

            int cost = Convert.ToInt32(count);

            if (cost > 0 && cost!=0)
            {
                
                sale.Show();
            }
           
        }

    }
}
