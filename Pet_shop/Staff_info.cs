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
    public partial class Staff_info : Form
    {
        public Staff_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_staff add = new Add_staff();
            add.Show();
        }
    }
}
