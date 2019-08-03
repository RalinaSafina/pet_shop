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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Connect = "server=localhost;user=root;database=pet_shop;password=root;";
            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();
            int id = int.Parse(textBox1.Text);
            MySqlCommand myCommand3 = new MySqlCommand("INSERT INTO orders VALUE(null, ?id, null, null, null, null);" ,myConnection);
            myCommand3.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            myCommand3.ExecuteNonQuery();
            MySqlCommand myCommand6 = new MySqlCommand("SELECT * FROM orders WHERE id_cust = ?id ORDER BY id_order DESC LIMIT 1;", myConnection);
            myCommand6.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            int ord = Convert.ToInt32(myCommand6.ExecuteScalar());
            label2.Text = Convert.ToString(ord);
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                MySqlCommand myCommand1 = new MySqlCommand();
                myCommand1.Connection = myConnection;
                int delivery = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                int payment = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                int pickup = Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
                myCommand1.CommandText = "CALL refresh_order(?payment, ?delivery, ?pickup, ?ord);";
                myCommand1.Parameters.Add("?delivery", MySqlDbType.Int32).Value = delivery;
                myCommand1.Parameters.Add("?ord", MySqlDbType.Int32).Value = ord;
                myCommand1.Parameters.Add("?payment", MySqlDbType.Int32).Value = payment;
                myCommand1.Parameters.Add("?pickup", MySqlDbType.Int32).Value = pickup;
                myCommand1.ExecuteNonQuery();
            }
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                int id_prod = Convert.ToInt32(dataGridView3.Rows[i].Cells[0].Value);
                int amount = Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value);
                myCommand.CommandText = "CALL add_to_order(?id_prod, ?ord, ?amount);";
                myCommand.Parameters.Add("?id_prod", MySqlDbType.Int32).Value = id_prod;
                myCommand.Parameters.Add("?ord", MySqlDbType.Int32).Value = ord;
                myCommand.Parameters.Add("?amount", MySqlDbType.Int32).Value = amount;
                myCommand.ExecuteNonQuery();
            }
            MySqlCommand myCommand2 = new MySqlCommand("CALL total_price_orders(?ord, ?id)", myConnection);
            myCommand2.Parameters.Add("?ord", MySqlDbType.Int32).Value = ord;
            myCommand2.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            myCommand2.ExecuteNonQuery();
            MySqlCommand myCommand5 = new MySqlCommand("SELECT sum FROM orders WHERE id_order = ?ord", myConnection);
            myCommand5.Parameters.Add("?ord", MySqlDbType.Int32).Value = ord;
            label5.Text = Convert.ToString(myCommand5.ExecuteScalar());
            MySqlCommand myCommand4 = new MySqlCommand("SELECT discount(?id)", myConnection);
            myCommand4.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            label4.Text = Convert.ToString(myCommand4.ExecuteScalar());
            myConnection.Close();
        }
    }
}
