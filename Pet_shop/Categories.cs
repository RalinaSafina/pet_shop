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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category categ = new Category(1);
            categ.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Category categ = new Category(9);
            categ.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Category categ = new Category(8);
            categ.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Category categ = new Category(7);
            categ.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Category categ = new Category(6);
            categ.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Category categ = new Category(5);
            categ.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Category categ = new Category(4);
            categ.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category categ = new Category(3);
            categ.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category categ = new Category(2);
            categ.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Category categ = new Category(10);
            categ.Show();
        }
    }
}
