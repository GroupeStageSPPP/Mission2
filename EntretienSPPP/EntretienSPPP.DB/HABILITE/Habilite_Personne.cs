using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Habilite_Personne
    {
        #region Attributs
        #endregion
        public int Identifiant { get; set; }
        
        public DateTime DateFin { get; set; }
        
        public Personne personne { get; set; }
        public Habilite habilite { get; set; }
        public Organisme organisme { get; set; }
        #region Propriétés

        #endregion

        #region Constructeurs

        #endregion

        #region Méthodes

        #endregion
    }
}
