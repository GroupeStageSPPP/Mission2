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
    public static class CompetenceDB
    {
        /// <summary>
        /// Récupère une liste de Competence à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Competence> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = "SELECT Identifiant, Libelle FROM Competence";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Competence> list = new List<Competence>();
            while (dataReader.Read())
            {

                //1 - Créer un Competence à partir des donner de la ligne du dataReader
                Competence competence = new Competence();
                competence.Identifiant = dataReader.GetInt32(0);
                competence.Libelle = dataReader.GetString(1);

                //2 - Ajouter ce Competence à la list de client
                list.Add(competence);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Competence à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Competence</param>
        /// <returns>Un Competence </returns>
        public static Competence Get(Int32 identifiant)
        {
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = @"SELECT Identifiant, Libelle FROM Competence
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Competence
            Competence competence = new Competence();

            competence.Identifiant = dataReader.GetInt32(0);
            competence.Libelle = dataReader.GetString(1);

            dataReader.Close();
            connection.Close();
            return competence;
        }

        public static void Insert(Competence Competence)
        {
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = @"INSERT INTO Competence (Libelle)
                                VALUES @Libelle";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Libelle", Competence.Libelle);

            //Execution
            connection.Open();
            
            commande.ExecuteNonQuery();
            connection.Close();
        }
        
        public static void Update(Competence Competence)
        {
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = @"UPDATE Competence 
                               SET Libelle = @Libelle
                               WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Libelle", Competence.Libelle);
            commande.Parameters.AddWithValue("Identifiant", Competence.Identifiant);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(Int32 Identifiant)
        {
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = @"DELETE FROM Competence 
                               WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", Identifiant);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }



    }
}
