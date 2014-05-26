using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EntretienSPPP.DB
{
    public static class SatisfactionDB
    {
        /// <summary>
        /// Récupère une liste de Satisfaction à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Satisfaction> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = "SELECT IdentifiantEntretien, Ambiance, Materiel, Secteur, Cadre, Futur, MesIdees, ReunionService, LaDirection, EvolutionMission, MonService, MonSite, AutreSite  FROM Satisfaction";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Satisfaction> list = new List<Satisfaction>();
            while (dataReader.Read())
            {

                //1 - Créer un Satisfaction à partir des donner de la ligne du dataReader
                Satisfaction satisfaction = new Satisfaction();
                satisfaction.IdentifiantEntretien = dataReader.GetInt32(0);
                satisfaction.Ambiance = dataReader.GetInt16(1);
                satisfaction.Materiel = dataReader.GetInt16(2);
                satisfaction.Secteur = dataReader.GetInt16(3);
                satisfaction.Cadre = dataReader.GetInt16(4);
                satisfaction.Futur = dataReader.GetInt16(5);
                satisfaction.MesIdees = dataReader.GetInt16(6); ;
                satisfaction.ReunionService = dataReader.GetInt16(7);
                satisfaction.LaDirection = dataReader.GetInt16(8);
                satisfaction.EvolutionMission = dataReader.GetString(9);
                satisfaction.MonService = dataReader.GetString(10);
                satisfaction.MonSite = dataReader.GetString(11);
                satisfaction.AutreSite = dataReader.GetString(12);





                //2 - Ajouter ce Satisfaction à la list de client
                list.Add(satisfaction);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Satisfaction à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Satisfaction</param>
        /// <returns>Un Satisfaction </returns>
        public static Satisfaction Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"SELECT Identifiant, Ambiance, Materiel, Secteur, Cadre, Futur, MesIdees, ReunionService, LaDirection, EvolutionMission, MonService, MonSite, AutreSite FROM Satisfaction
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Satisfaction
            Satisfaction satisfaction = new Satisfaction();

            satisfaction.Identifiant = dataReader.GetInt32(0);
            satisfaction.Ambiance = dataReader.GetInt16(1);
            satisfaction.Materiel = dataReader.GetInt16(2);
            satisfaction.Secteur = dataReader.GetInt16(3);
            satisfaction.Cadre = dataReader.GetInt16(4);
            satisfaction.Futur = dataReader.GetInt16(5);
            satisfaction.MesIdees = dataReader.GetInt16(6);
            satisfaction.ReunionService = dataReader.GetInt16(7);
            satisfaction.LaDirection = dataReader.GetInt16(8);
            satisfaction.EvolutionMission = dataReader.GetString(9);
            satisfaction.MonService = dataReader.GetString(10);
            satisfaction.MonSite = dataReader.GetString(11);
            satisfaction.AutreSite = dataReader.GetString(12);
            dataReader.Close();
            connection.Close();
            return satisfaction;
        }
    }
}
