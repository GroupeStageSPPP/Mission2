using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB
{
    public class IdentificationDB
    {
        public bool Verification(string login, string motDePasse)
        {
            /*
            * Code verification identifiants sur la base de donnée
            */
            if ((login == "admin") && (motDePasse == "admin"))
            {
                return true;
            }
            if ((login == "nonadmin") && (motDePasse == "nonadmin"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificationAdminAcess(string login)
        {
            /*
            * Code verification identifiants sur la base de donnée
            */
            if (login == "admin")
            {
                return true;
            }
            if (login == "nonadmin")
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}