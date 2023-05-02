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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection maConnexion = new MySqlConnection("server=127.0.0.1;user=root;database=gsb;port=3306;password=");
            maConnexion.Open();


            string sql = "INSERT INTO region(code_region,nom_region,budget_regional) VALUES(2, '" + textBox2.Text.Replace("'", "\\'") + "', ' " + textBox1.Text.Replace("'", "\\'") + "');";
            MySqlCommand maReq = new MySqlCommand(sql, maConnexion);
            maReq.ExecuteNonQuery();


            maConnexion.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
        }
    }
}
