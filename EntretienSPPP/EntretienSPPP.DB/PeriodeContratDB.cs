using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB
{
    public static class PeriodeContratDB
    {
        public static List<PeriodeContrat> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = "SELECT Identifiant, DateFinPeriode, IdentifiantContrat  FROM PeriodeContrat;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<PeriodeContrat> list = new List<PeriodeContrat>();
            while (dataReader.Read())
            {

                //1 - Créer un PeriodeContrat à partir des donner de la ligne du dataReader
                PeriodeContrat periodeContrat = new PeriodeContrat();
                periodeContrat.Identifiant = dataReader.GetInt32(0);
                periodeContrat.DateFinPeriode = dataReader.GetDateTime(1);
                periodeContrat.contrat = dataReader.GetInt32(2);



                //2 - Ajouter ce PeriodeContrat à la list de client
                list.Add(periodeContrat);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une PeriodeContrat à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de PeriodeContrat</param>
        /// <returns>Un PeriodeContrat </returns>
        public static PeriodeContrat Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = @"SELECT Identifiant, DateFinPeriode, IdentifiantContrat FROM PeriodeContrat
                                WHERE Identifiant = @Identifiant;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du PeriodeContrat
            PeriodeContrat periodeContrat = new PeriodeContrat();

            periodeContrat.Identifiant = dataReader.GetInt32(0);
            periodeContrat.DateFinPeriode = dataReader.GetDateTime(1);
            periodeContrat.contrat = dataReader.GetInt32(2);
            dataReader.Close();
            connection.Close();
            return periodeContrat;
        }

        public static void Insert(PeriodeContrat periodeContrat)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO PeriodeContrat ( DateFinPeriode, IdentifiantContrat)     
 
                                                       VALUES (@DateFinPeriode,                
                                                               @IdentifiantContrat);";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("DateFinPeriode", periodeContrat.DateFinPeriode);
            commande.Parameters.AddWithValue("IdentifiantContrat", periodeContrat.contrat);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(PeriodeContrat periodeContrat)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE PeriodeContrat
                               SET DateFin=@DateFin,              
                                   Identifiantcontrat=@IdentifiantContrat,
      
                               WHERE Identifiant=@Identifiant ;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Identifiant", periodeContrat.Identifiant);
            commande.Parameters.AddWithValue("DateFinPeriode", periodeContrat.DateFinPeriode);
            commande.Parameters.AddWithValue("IdentifiantContrat", periodeContrat.contrat);

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
            String requete = @"DELETE PeriodeContrat
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
