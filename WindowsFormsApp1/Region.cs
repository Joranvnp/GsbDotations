using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Region
    {
        private string code_region;
        private string nom_region;

        public Region(string laregion, string lenomregion)
        {
            this.code_region = laregion;
            this.nom_region = lenomregion;
           
        }
       
        public string getnomregion()
        {
            return this.nom_region;

        }
        public void setregion(string Lenouveaunomregion)
        {
            this.nom_region = Lenouveaunomregion;
        }
    }
    
}
