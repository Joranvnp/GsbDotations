using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Equipement
    {
        private string type;
        private string reference;
        private string prix;
        public Equipement(string leType, string laReference)
        {
            this.type = leType;
            this.reference = laReference;
         
        }

        public Equipement(string leType)
        {
            this.type = leType;
            
        }

        public string getType()
        {
            return this.type;
        }

        public void setType(string eTYpe)
        {
            this.type = eTYpe;
        }


        public string getReference()
        {
            return this.reference;
        }

        public void setReference(string eReference)
        {
            this.reference = eReference;
        }
        public string getPrix()
        {
            return this.prix;
        }

        public void setPrix(string eprix)
        {
            this.prix = eprix;
        }
        public override string ToString()
        {
            return this.type + " " + this.reference + " " + this.prix ;
        }

    }
}
