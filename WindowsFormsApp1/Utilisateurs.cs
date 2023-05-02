using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Utilisateurs
    {
        private string login;
        private string mdp;

        public Utilisateurs(string leLogin, string leMdp)
        {
            this.login = leLogin;
            this.mdp = leMdp;
        }

        public string getLogin()
        {
            return this.login;
        }

        public string getMdp()
        {
            return this.mdp;
        }
    }
}
