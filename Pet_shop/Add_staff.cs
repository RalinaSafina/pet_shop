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
    public partial class Add_staff : Form
    {
        public Add_staff()
        {
            InitializeComponent();
        }

        private void Add_staff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connect = "server=localhost;user=root;database=pet_shop;password=root;";
            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                string name = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                string passport = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                string inn = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                string workbook = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                string bank = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                string phone = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                string address = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                int salary = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
                int shop = Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
                myCommand.CommandText = "CALL add_staff(?name, ?passport, ?inn, ?workbook, ?bank, ?phone, ?address, ?salary, ?shop);";
                myCommand.Parameters.Add("?name", MySqlDbType.VarChar).Value = name;
                myCommand.Parameters.Add("?passport", MySqlDbType.VarChar).Value = passport;
                myCommand.Parameters.Add("?inn", MySqlDbType.VarChar).Value = inn;
                myCommand.Parameters.Add("?workbook", MySqlDbType.VarChar).Value = workbook;
                myCommand.Parameters.Add("?bank", MySqlDbType.VarChar).Value = bank;
                myCommand.Parameters.Add("?phone", MySqlDbType.VarChar).Value = phone;
                myCommand.Parameters.Add("?address", MySqlDbType.VarChar).Value = address;
                myCommand.Parameters.Add("?salary", MySqlDbType.Int32).Value = salary;
                myCommand.Parameters.Add("?shop", MySqlDbType.Int32).Value = shop;
                myCommand.ExecuteNonQuery();   
            }
            myConnection.Close();
            dataGridView1.Rows.Clear();
        }
    }
}
