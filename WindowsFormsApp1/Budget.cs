using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Budget
    {
        private string code_budget;
        private decimal budget_nationnal;
        private int anneebudget;
        public Budget(string lecodebudget, decimal lebudgetnationnal , int uneanneebudget)
        {
            this.code_budget = lecodebudget;
            this.budget_nationnal = lebudgetnationnal;
            this.anneebudget = uneanneebudget;

        }
   
        public decimal getbudgetnationnal()
        {
            return this.budget_nationnal;

        }
        public void setbudgetnationnal(decimal Lenouveaubudgetnationnal)
        {
            this.budget_nationnal = Lenouveaubudgetnationnal;
        }
        public int getanneebudget()
        {
            return this.anneebudget;

        }
        public void setanneebudget(int nouvelleannee)
        {
            this.anneebudget = nouvelleannee;
        }
    }
   
}
