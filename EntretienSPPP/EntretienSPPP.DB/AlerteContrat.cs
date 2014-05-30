using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class AlerteContrat
    {
        #region Propriété
        public int Identifiant { get; set; }
        public String Type { get; set; }
        public DateTime  DateAlerte { get; set; }
        public Int32 contrat { get; set; }

        #endregion

        #region Constructeurs
        public AlerteContrat()
        {
                
        }
        #endregion

        #region Méthodes
        
        #endregion
    }
}
