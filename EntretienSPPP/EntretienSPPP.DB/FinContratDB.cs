using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB
{
    public static class FinContratDB
    {
        public static List<FinContrat> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = "SELECT Identifiant, DateFin, IdentifiantContrat  FROM FinContrat;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<FinContrat> list = new List<FinContrat>();
            while (dataReader.Read())
            {

                //1 - Créer un FinContrat à partir des donner de la ligne du dataReader
                FinContrat finContrat = new FinContrat();
                finContrat.Identifiant = dataReader.GetInt32(0);
                finContrat.DateFin = dataReader.GetDateTime(1);
                finContrat.contrat = dataReader.GetInt32(2);



                //2 - Ajouter ce FinContrat à la list de client
                list.Add(finContrat);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une FinContrat à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de FinContrat</param>
        /// <returns>Un FinContrat </returns>
        public static FinContrat Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = @"SELECT Identifiant, DateFin, IdentifiantContrat FROM FinContrat
                                WHERE Identifiant = @Identifiant;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du FinContrat
            FinContrat finContrat = new FinContrat();

            finContrat.Identifiant = dataReader.GetInt32(0);
            finContrat.DateFin = dataReader.GetDateTime(1);
            finContrat.contrat = dataReader.GetInt32(2);
            dataReader.Close();
            connection.Close();
            return finContrat;
        }

        public static void Insert(FinContrat finContrat)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO FinContrat ( DateFin, IdentifiantContrat)     
 
                                                       VALUES (@DateFin,                
                                                               @IdentifiantContrat);";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("DateFin", finContrat.DateFin);
            commande.Parameters.AddWithValue("IdentifiantContrat", finContrat.contrat);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(FinContrat finContrat)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE FinContrat
                               SET DateFin=@DateFin,              
                                   Identifiantcontrat=@IdentifiantContrat,
      
                               WHERE Identifiant=@Identifiant ;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Identifiant", finContrat.Identifiant);
            commande.Parameters.AddWithValue("DateFin", finContrat.DateFin);
            commande.Parameters.AddWithValue("IdentifiantContrat", finContrat.contrat);

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
            String requete = @"DELETE FinContrat
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
