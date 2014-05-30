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
        public Int32 inaptitude { get; set; }
        public Int32 personne { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
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
