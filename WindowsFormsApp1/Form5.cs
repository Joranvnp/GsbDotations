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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MySqlConnection maConnexion = new MySqlConnection("server=127.0.0.1;user=root;database=gsb;port=3306;password=");
            maConnexion.Open();

            
            string list = "select code_facture,date_d_achat,visiteur from facture";
            MySqlCommand malist = new MySqlCommand(list, maConnexion);
            MySqlDataReader resultats = malist.ExecuteReader();
            
            while (resultats.Read())
            {
                Facture leMontant = new Facture(resultats[0].ToString(),Convert.ToDateTime(resultats[1].ToString()));
                listBox4.Items.Add(leMontant);
              
            }
            maConnexion.Close();

           

            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maConnexion = new MySqlConnection("server=127.0.0.1;user=root;database=gsb;port=3306;password=");
            maConnexion.Open();

            string index = listBox4.SelectedItem.ToString();

            string list = "SELECT fournisseur_equipement,typeequipement FROM facture where visiteur ='" + index + "';";
            MySqlCommand malist = new MySqlCommand(list, maConnexion);
            MySqlDataReader resultats = malist.ExecuteReader();
            while (resultats.Read())
            {
                Equipement lefour = new Equipement(resultats[0].ToString());
                textBox1.Text = lefour.ToString();
                Equipement letype = new Equipement(resultats[1].ToString());
                textBox2.Text = letype.ToString();



            }
            maConnexion.Close();
        }
    }
}
