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

        public Int32 formation { get; set; }
        public Int32 personne { get; set; }
        public Int32 organisme { get; set; }

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
