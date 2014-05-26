using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Formation
    {
        #region Attributs
        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        public Organisme organisme { get; set; }
        public string Titre { get; set; }
        public string Objectif { get; set; }
        public char Interne { get; set; }
        public char Externe { get; set; }
 
        #endregion

        #region Constructeurs
        public Formation()
        {

        }
        #endregion

        #region Méthodes

        #endregion
    }
}
