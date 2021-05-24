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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=pawnshop");
        MySqlCommand command;
        private void Form1_Load(object sender, EventArgs e)
        {
            zxc();
        }
        public void zxc()
        {
            string selectQuery = "SELECT * FROM `клиент`";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPatronymic.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxNumber.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxInf.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
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
                else {
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

     

        private void Update_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `клиент` SET `Фамилия`='" + textBoxSurname.Text + "',`Имя`='" + textBoxName.Text + "',`Отчество`='" + textBoxPatronymic.Text + "',`Адрес`='" + textBoxAddress.Text + "',`НомерТелефона`='" + textBoxNumber.Text + "',`ДопИнформация`= " + textBoxInf.Text + " WHERE id="+int.Parse(textBoxID.Text);
            executeMyQuery(updateQuery);
            zxc();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO `клиент`(`Фамилия`, `Имя`, `Отчество`, `Адрес`, `НомерТелефона`, `ДопИнформация`) VALUES('" + textBoxSurname.Text + "','" + textBoxName.Text + "','" + textBoxPatronymic.Text + "','" + textBoxAddress.Text + "','" + textBoxNumber.Text + "'," + textBoxInf.Text + ")";
            executeMyQuery(insertQuery);
            zxc();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string deleteQuery= "DELETE FROM `клиент` WHERE id="+int.Parse(textBoxID.Text);
            executeMyQuery(deleteQuery);
            zxc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }
    }
}
