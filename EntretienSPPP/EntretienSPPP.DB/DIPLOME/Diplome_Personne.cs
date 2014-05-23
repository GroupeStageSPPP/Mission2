using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.library
{
    public class Diplome_Personne
    {
        #region Attributs
        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        public DateTime DateObtention { get; set; }
        public Diplome diplome { get; set; }
        public Personne personne { get; set; }

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
