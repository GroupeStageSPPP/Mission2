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
        public int Identifiant { get; set; }
        public String Niveau { get; set; }
        public Char Utilite { get; set; }
        public Personne personne { get; set; }
        public Langue langue { get; set; }
        #region Propriétés

        #endregion

        #region Constructeurs

        #endregion

        #region Méthodes

        #endregion
    }
}
