using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT IdentifiantEntretien, Relation, Qualite, Realisation, Polyvalence, Assiduite, Motivation, Autonomie, RespectConsigne FROM Evaluation";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Evaluation> list = new List<Evaluation>();
            while (dataReader.Read())
            {

                //1 - Créer un Evaluation à partir des donner de la ligne du dataReader
                Evaluation evaluation = new Evaluation();
                evaluation.IdentifiantEntretien = dataReader.GetInt32(0);
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
        /// <param name="IdentifiantEntretien">Identifant de Evaluation</param>
        /// <returns>Un Evaluation </returns>
        public static Evaluation Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT IdentifiantEntretien, Relation, Qualite, Realisation, Polyvalence, Assiduite, Motivation, Autonomie, RespectConsigne FROM Evaluation
                                WHERE IdentifiantEntretien = @IdentifiantEntretien";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("IdentifiantEntretien", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Evaluation
            Evaluation evaluation = new Evaluation();

            evaluation.IdentifiantEntretien  = dataReader.GetInt32(0);
            evaluation.Relation              = dataReader.GetInt16(1);
            evaluation.Qualite               = dataReader.GetInt16(2);
            evaluation.Realisation           = dataReader.GetInt16(3);
            evaluation.Polyvalence           = dataReader.GetInt16(4);
            evaluation.Assiduite             = dataReader.GetInt16(5);
            evaluation.Motivation            = dataReader.GetInt16(6);
            evaluation.Autonomie             = dataReader.GetInt16(7);
            evaluation.RespectConsigne       = dataReader.GetInt16(8);
            dataReader.Close();
            connection.Close();
            return evaluation;
        }

        public static void Insert(Evaluation Evaluation)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO Evaluation (Relation, Qualite, Realisation, Polyvalence, Assiduite, Motivation, Autonomie, RespectConsigne)
                               VALUES (@Relation, @Qualite, @Realisation, @Polyvalence, @Assiduite, @Motivation, @Autonomie, @RespectConsigne) 
                               SELECT SCOPE_IDENTITY() ;";

            connection.Open();
            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Relation", Evaluation.Relation);
            commande.Parameters.AddWithValue("Qualite", Evaluation.Qualite);
            commande.Parameters.AddWithValue("Realisation", Evaluation.Realisation);
            commande.Parameters.AddWithValue("Polyvalence", Evaluation.Polyvalence);
            commande.Parameters.AddWithValue("Assiduite", Evaluation.Assiduite);
            commande.Parameters.AddWithValue("Motivation", Evaluation.Motivation);
            commande.Parameters.AddWithValue("Autonomie", Evaluation.Autonomie);
            commande.Parameters.AddWithValue("RespectConsigne", Evaluation.RespectConsigne);
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Evaluation Evaluation)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE Evaluation
                               SET Relation=@Relation, 
                                   Qualite=@Qualite, 
                                   Realisation=@Realisation,
                                   Polyvalence=@Polyvalence, 
                                   Assiduite=@Assiduite, 
                                   Motivation=@Motivation, 
                                   Autonomie=@Autonomie, 
                                   RespectConsigne=@RespectConsigne,
                               WHERE IdentifiantEntretien=@IdentifiantEntretien ;";

            connection.Open();
            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("IdentifiantEntretien",     Evaluation.IdentifiantEntretien    );
            commande.Parameters.AddWithValue("Relation",        Evaluation.Relation       );
            commande.Parameters.AddWithValue("Qualite",         Evaluation.Qualite        );
            commande.Parameters.AddWithValue("Realisation",     Evaluation.Realisation    );
            commande.Parameters.AddWithValue("Polyvalence",     Evaluation.Polyvalence    );
            commande.Parameters.AddWithValue("Assiduite",       Evaluation.Assiduite      );
            commande.Parameters.AddWithValue("Motivation",      Evaluation.Motivation     );
            commande.Parameters.AddWithValue("Autonomie",       Evaluation.Autonomie      );
            commande.Parameters.AddWithValue("RespectConsigne", Evaluation.RespectConsigne); 
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(Int32 IdentifiantEntretien)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"DELETE Evaluation
                               WHERE IdentifiantEntretien=@IdentifiantEntretien ;";

            connection.Open();
            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("IdentifiantEntretien", IdentifiantEntretien);

            commande.ExecuteNonQuery();
            connection.Close();
        }
    }
}
