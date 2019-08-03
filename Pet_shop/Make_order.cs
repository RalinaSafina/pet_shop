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

namespace Pet_shop
{
    public partial class Make_order : Form
    {
        public Make_order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new_cust cust = new new_cust();
            cust.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order ord = new order();
            ord.Show();
        }
    }
}
