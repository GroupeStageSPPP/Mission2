using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB
{
    public class Identification : IdentificationDB
    {
        public Boolean Status { get; set; }
        public String Identifiant { get; set; }
        public Boolean AdminAcess { get; set; }

        public Identification()
        {
            this.Status = false;
            this.Identifiant = null;
            this.AdminAcess = false;
        }
    }
}
