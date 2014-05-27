using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Diplome_Personne
    {
        #region Attributs
        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        public DateTime DateObtention { get; set; }
        public Int32 diplome { get; set; }
        public Int32 personne { get; set; }

        #endregion

        #region Constructeurs
        public Diplome_Personne()
        {
        }
        #endregion

        #region Méthodes

        #endregion
    }
}
