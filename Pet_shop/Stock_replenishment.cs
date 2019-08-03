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
    public partial class Stock_replenishment : Form
    {
        public Stock_replenishment()
        {
            InitializeComponent();
        }

        private void Stock_replenishment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connect = "server=localhost;user=root;database=pet_shop;password=root;";
            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();
            int id_pick = int.Parse(textBox1.Text);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                int id_prod = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                int amount = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                myCommand.CommandText = "CALL stock_replenishment(?id_prod, ?id_pick, ?amount);";
                myCommand.Parameters.Add("?id_prod", MySqlDbType.Int32).Value = id_prod;
                myCommand.Parameters.Add("?id_pick", MySqlDbType.Int32).Value = id_pick;
                myCommand.Parameters.Add("?amount", MySqlDbType.Int32).Value = amount;
                myCommand.ExecuteNonQuery();
            }
            myConnection.Close();
            dataGridView1.Rows.Clear();
            textBox1.Clear();
        }
    }
}
