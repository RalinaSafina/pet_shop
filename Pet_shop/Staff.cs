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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connect = "server=localhost;user=root;database=pet_shop;password=root;";
            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();
            int id = int.Parse(textBox1.Text);
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM staff WHERE id_staff = ?id;", myConnection);
            myCommand.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            MySqlDataReader reader = myCommand.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = reader[0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = reader[1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = reader[2].ToString();
                dataGridView1.Rows[i].Cells[3].Value = reader[3].ToString();
                dataGridView1.Rows[i].Cells[4].Value = reader[4].ToString();
                dataGridView1.Rows[i].Cells[5].Value = reader[5].ToString();
                dataGridView1.Rows[i].Cells[6].Value = reader[6].ToString();
                dataGridView1.Rows[i].Cells[7].Value = reader[7].ToString();
                dataGridView1.Rows[i].Cells[8].Value = reader[8].ToString();
                i++;
            }
            reader.Close();
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.Rows.Clear();
        }
    }
}
