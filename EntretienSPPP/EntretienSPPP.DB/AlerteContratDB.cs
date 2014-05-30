using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB
{
    public static class AlerteContratDB
    {
        /// <summary>
        /// Récupère une liste de AlerteContrat à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<AlerteContrat> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = "SELECT Identifiant, DateAlerte, IdentifiantContrat, Type  FROM AlerteContrat;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<AlerteContrat> list = new List<AlerteContrat>();
            while (dataReader.Read())
            {

                //1 - Créer un AlerteContrat à partir des donner de la ligne du dataReader
                AlerteContrat alerteContrat = new AlerteContrat();
                alerteContrat.Identifiant = dataReader.GetInt32(0);
                alerteContrat.DateAlerte = dataReader.GetDateTime(1);
                alerteContrat.contrat = dataReader.GetInt32(2);
                alerteContrat.Type = dataReader.GetString(3);



                //2 - Ajouter ce AlerteContrat à la list de client
                list.Add(alerteContrat);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une AlerteContrat à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de AlerteContrat</param>
        /// <returns>Un AlerteContrat </returns>
        public static AlerteContrat Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = @"SELECT Identifiant, DateAlerte, IdentifiantContrat, Type FROM AlerteContrat
                                WHERE Identifiant = @Identifiant;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du AlerteContrat
            AlerteContrat alerteContrat = new AlerteContrat();

            alerteContrat.Identifiant = dataReader.GetInt32(0);
            alerteContrat.DateAlerte = dataReader.GetDateTime(1);
            alerteContrat.contrat = dataReader.GetInt32(2);
            alerteContrat.Type = dataReader.GetString(3);
            dataReader.Close();
            connection.Close();
            return alerteContrat;
        }

        public static void Insert(AlerteContrat alerteContrat)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO AlerteContrat ( DateAlerte, IdentifiantContrat, Type)      
 
                                                       VALUES (@DateAlerte,                
                                                               @IdentifiantContrat,              
                                                               @Type);";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("DateAlerte", alerteContrat.DateAlerte);
            commande.Parameters.AddWithValue("contrat", alerteContrat.contrat);
            commande.Parameters.AddWithValue("Type", alerteContrat.Type);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(AlerteContrat alerteContrat)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE AlerteContrat
                               SET DateAlerte=@DateAlerte,              
                                   contrat=@contrat,            
                                   Type=@Type,         
                               WHERE Identifiant=@Identifiant ;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Identifiant", alerteContrat.Identifiant);
            commande.Parameters.AddWithValue("DateAlerte", alerteContrat.DateAlerte);
            commande.Parameters.AddWithValue("contrat", alerteContrat.contrat);
            commande.Parameters.AddWithValue("Type", alerteContrat.Type);

            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(Int32 Identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"DELETE AlerteContrat
                               WHERE Identifiant=@Identifiant ;";


            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Identifiant", Identifiant);

            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }
    }
}
