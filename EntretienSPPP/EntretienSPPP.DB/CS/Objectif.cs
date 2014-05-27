using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Objectif
    {
        #region Attribut
        
        #endregion
        #region Propriété
        public Int32 Identifiant { get; set; }
        public string Mesure { get; set; }
        public string Description { get; set; }
        public string Resultat { get; set; }
        public Int32 IdentifiantEntretien { get; set; }
        #endregion
        #region Constructeur
        public Objectif()
        {
                
        }
        #endregion
        #region Méthodes
        
        #endregion
    }
}
