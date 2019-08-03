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
    public partial class Category : Form
    {
        public Category(int category)
        {
            InitializeComponent();
            string Connect = "server=localhost;user=root;database=pet_shop;password=root;";
            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM product WHERE id_category = ?categ;", myConnection);
            myCommand.Parameters.Add("?categ", MySqlDbType.Int32).Value = category;
            MySqlDataReader reader = myCommand.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = reader[0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = reader[1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = reader[2].ToString();
                dataGridView1.Rows[i].Cells[3].Value = reader[4].ToString();
                if (reader[5].ToString() == "False")
                    dataGridView1.Rows[i].Cells[4].Value = "m";
                else
                    dataGridView1.Rows[i].Cells[4].Value = "f";
                dataGridView1.Rows[i].Cells[5].Value = reader[6].ToString();
                i++;
            }
            reader.Close();
            myConnection.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            
        }
    }
}
