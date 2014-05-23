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
    public static class SeniorDB
    {
        /// <summary>
        /// Récupère une liste de Senior à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Senior> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = "SELECT IdentifiantEntretien, PAS, DIF, BilanCompetence, TempsTravail, TransfertCompetence FROM Senior";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Senior> list = new List<Senior>();
            while (dataReader.Read())
            {

                Senior senior = new Senior();
                senior.Identifiant = dataReader.GetInt32(0);
                senior.PAS = dataReader.GetChar(1);
                senior.DIF = dataReader.GetChar(2);
                senior.BilanCompetence = dataReader.GetChar(3);
                senior.TempsTravail = dataReader.GetChar(4);
                senior.TransfertCompetence = dataReader.GetChar(5);


                //2 - Ajouter ce Senior à la list de client
                list.Add(senior);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Senior à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Senior</param>
        /// <returns>Un Senior </returns>
        public static Senior Get(Int32 identifiant)
        {
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = @"SELECT IdentifiantEntretien, PAS, DIF, BilanCompetence, TempsTravail, TransfertCompetence FROM Senior
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Senior
            Senior senior = new Senior();

            senior.Identifiant = dataReader.GetInt32(0);
            senior.PAS = dataReader.GetChar(1);
            senior.DIF = dataReader.GetChar(2);
            senior.BilanCompetence = dataReader.GetChar(3);
            senior.TempsTravail = dataReader.GetChar(4);
            senior.TransfertCompetence = dataReader.GetChar(5);
            dataReader.Close();
            connection.Close();
            return senior;
        }

        public static void Insert(Senior Senior)
        {
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = @"INSERT INTO Senior (IdentifiantEntretien, PAS, DIF, BilanCompetence, TempsTravail, TransfertCompetence)
                                VALUES (@IdentifiantEntretien, @PAS, @DIF, @BilanCompetence, @TempsTravail, @TransfertCompetence)";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("IdentifiantEntretien", Senior.Identifiant);
            commande.Parameters.AddWithValue("PAS", Senior.PAS);
            commande.Parameters.AddWithValue("DIF", Senior.DIF);
            commande.Parameters.AddWithValue("BilanCompetence", Senior.BilanCompetence);
            commande.Parameters.AddWithValue("TempsTravail", Senior.TempsTravail);
            commande.Parameters.AddWithValue("TransfertCompetence", Senior.TransfertCompetence);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Senior Senior)
        {
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = @"UPDATE Senior 
                               SET , PAS = @PAS, DIF = @DIF, BilanCompetence = @BilanCompetence, TempsTravail = @TempsTravail, TransfertCompetence = @TransfertCompetence
                               WHERE IdentifiantEntretien = @IdentifiantEntretien";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("IdentifiantEntretien", Senior.Identifiant);
            commande.Parameters.AddWithValue("PAS", Senior.PAS);
            commande.Parameters.AddWithValue("DIF", Senior.DIF);
            commande.Parameters.AddWithValue("BilanCompetence", Senior.BilanCompetence);
            commande.Parameters.AddWithValue("TempsTravail", Senior.TempsTravail);
            commande.Parameters.AddWithValue("TransfertCompetence", Senior.TransfertCompetence);
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
            String requete = @"DELETE FROM Senior 
                               WHERE IdentifiantEntretien = @IdentifiantEntretien";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("IdentifiantEntretien", Identifiant);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }
    }
}
