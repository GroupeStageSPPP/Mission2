using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class EvaluationMoi
    {
        #region Attribut
        
        #endregion
        #region Propriété
        
        public Int32 IdentifiantEntretien { get; set; }
        public Int16 Communication { get; set; }
        public Int16 SensRelationnel { get; set; }
        public Int16 Implication { get; set; }
        public Int16 Competence { get; set; }
        public Int16 Performance { get; set; }
        public Int16 Management { get; set; }
        public Int16 Objectifs { get; set; }
        public string Commentaire { get; set; }
        #endregion
        #region Constructeur
        public EvaluationMoi()
        {
                
        }
        #endregion
        #region Méthodes
        
        #endregion
    }
}
