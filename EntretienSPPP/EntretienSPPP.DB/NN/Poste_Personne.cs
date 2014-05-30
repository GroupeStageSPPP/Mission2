using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
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
        public Double Coefficient { get; set; }
        public Int32 personne { get; set; }
        public Int32 poste { get; set; }
        public string Contrat { get; set; }
        public Int32 site { get; set; }

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
