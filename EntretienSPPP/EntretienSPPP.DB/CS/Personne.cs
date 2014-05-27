using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Personne
    {
        #region Attributs

        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public Int32 famille { get; set; }
        public Int32 genre { get; set; }
        #endregion

        #region Constructeurs
        public Personne()
        {

        }
        #endregion

        #region Méthodes

        #endregion
    }
}
