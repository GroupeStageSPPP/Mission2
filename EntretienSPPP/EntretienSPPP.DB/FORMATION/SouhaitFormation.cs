using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class SouhaitFormation
    {
        #region Attributs

        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        public string Objectif { get; set; }
        public char Interne { get; set; }
        public char Externe { get; set; }
        public string AvisPersonne { get; set; }
        public string AvisResponsable { get; set; }
        public Entretien entretien { get; set; }

        #endregion

        #region Constructeurs
        public SouhaitFormation()
        {

        }
        #endregion

        #region Méthodes

        #endregion
    }
}
