using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using EntretienSPPP.library;

namespace EntretienSPPP.DB
{
    public static class EvaluationDB
    {
        /// <summary>
        /// Récupère une liste de Evaluation à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Evaluation> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = "SELECT Identifiant, Relation, Qualite, Realisation, Polyvalence, Assiduite, Motivation, Autonomie, RespectConsigne FROM Evaluation";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Evaluation> list = new List<Evaluation>();
            while (dataReader.Read())
            {

                //1 - Créer un Evaluation à partir des donner de la ligne du dataReader
                Evaluation evaluation = new Evaluation();
                evaluation.Identifiant = dataReader.GetInt32(0);
                evaluation.Relation = dataReader.GetInt16(1);
                evaluation.Qualite = dataReader.GetInt16(2);
                evaluation.Realisation = dataReader.GetInt16(3);
                evaluation.Polyvalence = dataReader.GetInt16(4);
                evaluation.Assiduite = dataReader.GetInt16(5);
                evaluation.Motivation = dataReader.GetInt16(6);
                evaluation.Autonomie = dataReader.GetInt16(7);
                evaluation.RespectConsigne = dataReader.GetInt16(8);


                //2 - Ajouter ce Evaluation à la list de client
                list.Add(evaluation);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Evaluation à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Evaluation</param>
        /// <returns>Un Evaluation </returns>
        public static Evaluation Get(Int32 identifiant)
        {
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = @"SELECT Identifiant, Relation, Qualite, Realisation, Polyvalence, Assiduite, Motivation, Autonomie, RespectConsigne FROM Evaluation
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Evaluation
            Evaluation evaluation = new Evaluation();

            evaluation.Identifiant = dataReader.GetInt32(0);
            evaluation.Relation = dataReader.GetInt16(1);
            evaluation.Qualite = dataReader.GetInt16(2);
            evaluation.Realisation = dataReader.GetInt16(3);
            evaluation.Polyvalence = dataReader.GetInt16(4);
            evaluation.Assiduite = dataReader.GetInt16(5);
            evaluation.Motivation = dataReader.GetInt16(6);
            evaluation.Autonomie = dataReader.GetInt16(7);
            evaluation.RespectConsigne = dataReader.GetInt16(8);
            dataReader.Close();
            connection.Close();
            return evaluation;
        }
    }
}
