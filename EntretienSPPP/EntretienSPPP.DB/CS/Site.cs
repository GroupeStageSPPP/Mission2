using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Site
    {
        #region Attribut
        
        #endregion

        #region Propriété
        public int Identifiant { get; set; }
        public string Libelle { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }


        #endregion

        #region Constructeurs
        public Site()
        {
                
        }
        #endregion

        #region Méthodes
        
        #endregion
    }
}
