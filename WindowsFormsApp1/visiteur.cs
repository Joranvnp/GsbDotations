using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class visiteur
    {
        private string code_visiteur;
        private string nom_visiteur;
        private string prenom_visiteur;
        private string tel_visiteur;
        private string ville_visiteur;
        private string codepostal_visiteur;
        private string adresse_visiteur;

        public visiteur(string lecode, string lenom , string leprenom, string letel , string laville , string lecodepostal , string adresse)
        {
            this.code_visiteur = lecode;
            this.nom_visiteur = lenom;
            this.prenom_visiteur = leprenom;
            this.tel_visiteur = letel;
            this.ville_visiteur = laville; ;
            this.codepostal_visiteur = lecodepostal;
            this.adresse_visiteur = adresse;
        }

        public visiteur(string lenom, string leprenom)
        {
            this.nom_visiteur = lenom;
            this.prenom_visiteur = leprenom;
        }

        public string getNom()
        {
            return this.nom_visiteur;
            
        }
        public string getPrenom()
        {
            return this.prenom_visiteur;

        }
        public string getTel()
        {
            return this.tel_visiteur;

        }
        public string getCodepostal()
        {
            return this.codepostal_visiteur;

        }
        public string getVille()
        {
            return this.ville_visiteur;

        }
        public string getAdresse()
        {
            return this.adresse_visiteur;

        }

        public void setNom(string Lenouveaunom)
        {
            this.nom_visiteur = Lenouveaunom;
        }
        public void setPrenom(string Lenouveauprenom)
        {
            this.prenom_visiteur = Lenouveauprenom;
        }
        public void setTel(string Lenouveautel)
        {
            this.tel_visiteur = Lenouveautel;
        }
        public void setAdresse(string Lanouvelleadresse)
        {
            this.nom_visiteur = Lanouvelleadresse;
        }
        public void setVille(string Lanouvelleville)
        {
            this.ville_visiteur = Lanouvelleville;
        }
        public void setCodepostal(string Lenouveaucodepostal)
        {
            this.nom_visiteur = Lenouveaucodepostal;
        }
        public override string ToString()
        {
            return this.nom_visiteur + " " + this.prenom_visiteur;
        }

    }
}
