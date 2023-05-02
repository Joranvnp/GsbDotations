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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void AnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MySqlConnection maConnexion = new MySqlConnection("server=127.0.0.1;user=root;database=gsb;port=3306;password=");
            maConnexion.Open();


            string list = "select * from visiteur";
            MySqlCommand malist = new MySqlCommand(list, maConnexion);
            MySqlDataReader resultats = malist.ExecuteReader();
            while (resultats.Read())
            {
                visiteur leVisiteur = new visiteur(resultats[1].ToString() ,resultats[2].ToString());
                comboBox1.Items.Add(leVisiteur);
            }
            maConnexion.Close();

            MySqlConnection maConnexion2 = new MySqlConnection("server=127.0.0.1;user=root;database=gsb;port=3306;password=");
            maConnexion2.Open();

            string list2 = "select * from equipement";
            MySqlCommand malist2 = new MySqlCommand(list2, maConnexion2);
            MySqlDataReader resultats2 = malist2.ExecuteReader();
            while (resultats2.Read())
            {
                Equipement lequipement = new Equipement(resultats2[1].ToString(), resultats2[2].ToString());
                comboBox2.Items.Add(lequipement);
            }

           
            maConnexion.Close();
        }

        private void MenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {


            OpenFileDialog ouvrir = new OpenFileDialog();
            if (ouvrir.ShowDialog() == DialogResult.OK)
            {
                string fileName = ouvrir.FileName;
                textBox3.Text = fileName;
            }


        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
                   
            
     
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection maConnexion = new MySqlConnection("server=127.0.0.1;user=root;database=gsb;port=3306;password=");
            maConnexion.Open();

            String dt = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //"INSERT INTO facture(code_facture, date_d_achat, justificatif, fournisseur_equipement, prix_equipement) VALUES('13', '2000-12-05', 'de', 'fze', '12');"
            //"INSERT INTO facture (code_facture,date_d_achat,justificatif,fournisseur_equipement,prix_equipement) VALUES (13,'" + dt +"',' "+ textBox3.Text.Replace("'", "\\'") + "','" + textBox1.Text.Replace("'", "\\'") + "',' " + numericUpDown1.Value + " ');";
            string sql = "INSERT INTO facture(code_facture, date_d_achat, justificatif, fournisseur_equipement, prix_equipement,visiteur,typeequipement) VALUES(15, '" + dt +"', ' "+ textBox3.Text.Replace("'", "\\'") + "', '" + textBox1.Text.Replace("'", "\\'") + "', ' " + numericUpDown1.Value + " ','"+ comboBox1.Text.Replace("'", "\\'")+ "','" + comboBox2.Text.Replace("'", "\\'")+ "');";
            MySqlCommand maReq = new MySqlCommand(sql, maConnexion);
            maReq.ExecuteNonQuery();




            MessageBox.Show("fait");

            


            maConnexion.Close();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

        }
    }
}
    

