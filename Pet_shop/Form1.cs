using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categories categ = new Categories();
            categ.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Make_order m_o = new Make_order();
            m_o.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stock_replenishment rep = new Stock_replenishment();
            rep.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_to_an_order add = new Add_to_an_order();
            add.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Get_info get = new Get_info();
            get.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff_info st = new Staff_info();
            st.Show();
        }
    }
}
