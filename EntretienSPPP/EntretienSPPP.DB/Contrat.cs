using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Contrat
    {
        #region Attribut
        
        #endregion

        #region Propriété
        public int Identifiant { get; set; }
        public string Libelle { get; set; }
        public Int16 IsEssai { get; set; }
        public Int16 IsFinCtr { get; set; }

        #endregion

        #region Constructeurs
        public Contrat()
        {
                
        }
        #endregion

        #region Méthodes
        
        #endregion
    }
}
