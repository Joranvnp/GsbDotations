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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string login;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=gsb;port=3306;password=");
            sqlConnection.Open();
            string userType = "";
            string sql = "select utilisateur_mdp, utilisateur_type from utilisateurs where utilisateur_login = '" + textBox1.Text + "';";
            MySqlCommand maReq = new MySqlCommand(sql, sqlConnection);

            MySqlDataReader resultats = maReq.ExecuteReader();
            string resultatConnexion = "";


            while (resultats.Read())
            {
                //userType = resultats[0].ToString();

                string motDePasseSaisi = textBox2.Text;
                bool r = Password.VerifyPassword(resultats[0].ToString(), motDePasseSaisi);
                if (r == true)
                {
                    MessageBox.Show("Vous êtes authentifié");
                    userType = resultats[1].ToString();
                }
                else
                {
                    MessageBox.Show("Login/mdp incorrect");
                }
            }
            
            if (userType != "")
            {
                MessageBox.Show("Connexion réussi");
                userType = resultats[1].ToString();

                switch (userType)
                {
                    case "0":
                        MessageBox.Show("admin");

                        break;
                    case "1":
                        MessageBox.Show("secretaire");
                        Form3 form3 = new Form3();
                        this.Hide();
                        form3.ShowDialog();
                        break;
                    case "2":
                        MessageBox.Show("directionRegionale");

                        break;
                    case "3":
                        MessageBox.Show("responsableSecteur");
                        Form4 form4 = new Form4();
                        this.Hide();
                        form4.ShowDialog();
                        break;
                    case "4":
                        MessageBox.Show("directionGenerale");
                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.ShowDialog();
                        break;
                    case "5":
                        MessageBox.Show("test");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Mauvais utilisateur ou mot de passe");
            }

            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection maConnexion = new MySqlConnection("server=127.0.0.1;user=root;database=gsb;port=3306;password=");
            maConnexion.Open();

            string passwordHash = Password.HashPassword(textBox4.Text);

            string sql = "INSERT INTO utilisateurs (utilisateur_login, utilisateur_mdp, utilisateur_type) VALUES ('" + textBox3.Text.Replace("'", "\\'") + "', '" + passwordHash + "', '5')";
            MySqlCommand maReq = new MySqlCommand(sql, maConnexion);

            // Executer des requêtes non-SELECT (ne retournant aucun résultat)
             maReq.ExecuteNonQuery();

            maConnexion.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}