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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=pawnshop");
        MySqlCommand command;
        private void Form2_Load(object sender, EventArgs e)
        {
            zxc();
        }

        public void zxc()
        {
            string selectQuery = "SELECT * FROM `склад`";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxUniqueNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxFeatureCode.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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

        private void Insert2_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO `склад`(`НазваниеТовара`, `Цена`, `КодХарактеристики`) VALUES('" + textBoxProductName.Text + "','" + textBoxPrice.Text + "'," + textBoxFeatureCode.Text + ")";
            executeMyQuery(insertQuery);
            zxc();
        }

        private void Update2_Click(object sender, EventArgs e)
        {
          
            string updateQuery = "UPDATE `склад` SET `НазваниеТовара`='" + textBoxProductName.Text + "',`Цена`='" + textBoxPrice.Text + "',`КодХарактеристики`=" + textBoxFeatureCode.Text + " WHERE УникНомер=" + int.Parse(textBoxUniqueNumber.Text);
            executeMyQuery(updateQuery);
            zxc();
        }

        private void Delete2_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM `склад` WHERE УникНомер=" + int.Parse(textBoxUniqueNumber.Text);
            executeMyQuery(deleteQuery);
            zxc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }
    }
}
