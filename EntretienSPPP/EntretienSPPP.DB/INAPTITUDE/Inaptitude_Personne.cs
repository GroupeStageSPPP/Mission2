using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Inaptitude_Personne
    {
        #region Attributs

        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        public DateTime DateFin { get; set; }
        public char Definitif { get; set; }
        public Inaptitude inaptitude { get; set; }
        public Personne personne { get; set; }

        #endregion

        #region Constructeurs
        public Inaptitude_Personne()
        {

        }
        #endregion

        #region Méthodes

        #endregion
    }
}
