using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.library
{
    public class Poste_Personne
    {
        #region Attributs

        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Statut { get; set; }
        public float Coefficient { get; set; }
        public Personne personne { get; set; }
        public Poste poste { get; set; }
        public string Contrat { get; set; }
        public Site site { get; set; }

        #endregion

        #region Constructeurs
        public Poste_Personne()
        {
                
        }
        #endregion

        #region Méthodes

        #endregion
    }
}
