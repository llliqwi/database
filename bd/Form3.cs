using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=pawnshop");
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Client_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
        }

        private void Warehouse_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
        }
    }
}
