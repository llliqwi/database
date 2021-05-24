using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=pawnshop");
        MySqlCommand command;
        private void Form5_Load(object sender, EventArgs e)
        {
            zxc();
        }

        public void zxc()
        {
            string selectQuery = "SELECT * FROM `характеристика товара на складе`";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxProductCode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxCategory.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxProductCondition.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxReceiptDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxIdClient.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO `характеристика товара на складе`(`Категория`, `Состояние товара`, `Дата поступления`, `id клиента`) VALUES('" + textBoxCategory.Text + "','" + textBoxProductCondition.Text + "','" + textBoxReceiptDate.Text + "'," + textBoxIdClient.Text + ")";
            executeMyQuery(insertQuery);
            zxc();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `характеристика товара на складе` SET  `Категория`='" + textBoxCategory.Text + "',`Состояние товара`='" + textBoxProductCondition.Text + "',`Дата поступления`='" + textBoxReceiptDate.Text + "',`id клиента`=" + textBoxIdClient.Text+ " клиента WHERE Код товара=" + int.Parse(textBoxProductCode.Text);
            executeMyQuery(updateQuery);
            zxc();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM `характеристика товара на складе` WHERE Код товара=" + int.Parse(textBoxProductCode.Text);
            executeMyQuery(deleteQuery);
            zxc();
        }
    }
}
