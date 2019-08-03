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
    public partial class Get_info : Form
    {
        public Get_info()
        {
            InitializeComponent();
        }

        private void Get_info_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string Connect = "server=localhost;user=root;database=pet_shop;password=root;";
            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();
            int ord = int.Parse(textBox1.Text);
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM product_order WHERE id_order = ?ord;", myConnection);
            myCommand.Parameters.Add("?ord", MySqlDbType.Int32).Value = ord;
            MySqlDataReader reader = myCommand.ExecuteReader();
            int i = 0;
            while(reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = reader[0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = reader[2].ToString();
                dataGridView1.Rows[i].Cells[2].Value = reader[3].ToString();
                i++;
            }
            reader.Close();
            MySqlCommand myCommand1 = new MySqlCommand("SELECT sum FROM orders WHERE id_order = ?ord;", myConnection);
            myCommand1.Parameters.Add("?ord", MySqlDbType.Int32).Value = ord;
            label3.Text = Convert.ToString(myCommand1.ExecuteScalar());
            myConnection.Close();
        }
    }
}
