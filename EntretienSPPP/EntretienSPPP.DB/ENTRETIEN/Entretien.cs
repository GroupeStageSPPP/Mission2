using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.library
{
    public class Entretien
    {
        #region Attributs
        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        public DateTime DateDeb { get; set; }
        public DateTime DateFin { get; set; }
        public string Commentaire { get; set; }
        public Personne personne { get; set; }
        public char Expression { get; set; }
        public char DefinitionFonction { get; set; }
        public char ClareteFonction { get; set; }
        public char ClareteObjectif { get; set; }


        #endregion

        #region Constructeurs
        public Entretien()
        {

        }
        #endregion

        #region Méthodes

        #endregion
    }
}
