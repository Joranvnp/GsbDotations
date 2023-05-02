using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Facture
    {
        private string code_facture;
        private DateTime date_achat;
        private string prix;
   

        public Facture(string lecodefacture, DateTime ladate)
        {
            this.code_facture = lecodefacture;
            this.date_achat = ladate;

            
        }
        public Facture(string lePrix)
        {
            this.prix = lePrix;
           
         
        }
        public DateTime getdate()
        {
            return this.date_achat;

        }
        public void setdate(DateTime Lanouvelledate)
        {
            this.date_achat = Lanouvelledate;
        }
        public string getjustificatif()
        {
            return this.code_facture;

        }
       
        public string getPrix()
        {
            return this.prix;

        }
        public void setPrix(string Lenprix)
        {
            this.prix = Lenprix;
        }

       
        public override string ToString()
        {
            return this.code_facture + " " + this.date_achat;
        }

    }
}
