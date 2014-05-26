using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntretienSPPP.DB
{
    public class Satisfaction
    {
        #region Attributs

        #endregion

        #region Propriétés
        public Int32 IdentifiantEntretien { get; set; }
        public Int16 Ambiance { get; set; }
        public Int16 Materiel { get; set; }
        public Int16 Secteur { get; set; }
        public Int16 Cadre { get; set; }
        public Int16 Futur { get; set; }
        public Int16 MesIdees { get; set; }
        public Int16 ReunionService { get; set; }
        public Int16 LaDirection { get; set; }
        public string EvolutionMission { get; set; }
        public string MonService { get; set; }
        public string MonSite { get; set; }
        public string AutreSite { get; set; }


        #endregion

        #region Constructeurs
        public Satisfaction()
        {

        }
        #endregion

        #region Méthodes

        #endregion
    }
}
