using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class CV
    {
        #region Attributs
        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        public DateTime DateDeb { get; set; }
        public DateTime DateFin { get; set; }
        public string Entreprise { get; set; }
        public string Secteur { get; set; }
        public string Poste { get; set; }
        public Personne personne { get; set; }


        #endregion

        #region Constructeurs
        public CV()
        {

        }
        #endregion

        #region Méthodes

        #endregion
    }
}
