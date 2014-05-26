using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Formation_Personne
    {
        #region Attributs
        #endregion

        #region Propriétés
        public int Identifiant { get; set; }
        
        public DateTime Annee { get; set; }
        public string Contenu { get; set; }
        public string Documentation { get; set; }
        public string Formateur { get; set; }
        public string AvisResponsable { get; set; }
        
        public Formation formation { get; set; }
        public Personne personne { get; set; }
        public Organisme organisme { get; set; }

        #endregion

        #region Constructeurs
        public Formation_Personne()
        {

        }
        #endregion

        #region Méthodes

        #endregion
    }
}
