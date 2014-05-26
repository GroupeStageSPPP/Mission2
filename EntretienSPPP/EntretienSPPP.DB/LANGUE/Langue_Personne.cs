using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Langue_Personne
    {
        #region Attributs

        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        public string niveau { get; set; }
        public string Utilite { get; set; }
        public Langue langue { get; set; }
        public Personne personne { get; set; }

        #endregion

        #region Constructeurs
        public Langue_Personne()
        {

        }
        #endregion

        #region Méthodes

        #endregion
    }
}
