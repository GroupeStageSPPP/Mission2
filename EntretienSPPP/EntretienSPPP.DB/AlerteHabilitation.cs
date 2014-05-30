using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class AlerteHabilitation
    {
        #region Propriété
        public Int32 Identifiant { get; set; }
        public DateTime DateAlerte { get; set; }
        public Int32 habilitationPersonne { get; set; }

        #endregion

        #region Constructeurs
        public AlerteHabilitation()
        {
                
        }
        #endregion

        #region Méthodes
        
        #endregion
    }
}
