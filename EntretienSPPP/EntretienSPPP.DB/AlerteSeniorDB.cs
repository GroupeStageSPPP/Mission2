using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB
{
    public static class AlerteSeniorDB
    {
        /// <summary>
        /// Récupère une liste de AlerteSenior à partir de la base de données
        /// </summary>
        /// <returns>Une liste de AlerteSenior</returns>
        public static List<AlerteSenior> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = "SELECT Identifiant, DateAlerte, IdentifiantPersonne  FROM AlerteSenior";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<AlerteSenior> list = new List<AlerteSenior>();
            while (dataReader.Read())
            {

                //1 - Créer un AlerteSenior à partir des donner de la ligne du dataReader
                AlerteSenior alerteSenior = new AlerteSenior();
                alerteSenior.Identifiant = dataReader.GetInt32(0);
                alerteSenior.DateAlerte = dataReader.GetDateTime(1);
                alerteSenior.personne = dataReader.GetInt32(2);



                //2 - Ajouter ce AlerteSenior à la list de AlerteSenior
                list.Add(alerteSenior);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une AlerteSenior à partir d'un identifiant de AlerteSenior
        /// </summary>
        /// <param name="Identifiant">Identifiant de AlerteSenior</param>
        /// <returns>Un AlerteSenior </returns>
        public static AlerteSenior Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = @"SELECT Identifiant, DateAlerte, IdentifiantPersonne FROM AlerteSenior
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du AlerteSenior
            AlerteSenior alerteSenior = new AlerteSenior();

            alerteSenior.Identifiant = dataReader.GetInt32(0);
            alerteSenior.DateAlerte = dataReader.GetDateTime(1);
            alerteSenior.personne = dataReader.GetInt32(2);
            dataReader.Close();
            connection.Close();
            return alerteSenior;
        }

        public static void Insert(AlerteSenior FormationPersonne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO AlerteSenior ( DateAlerte, IdentifiantPersonne)    
 
                                                       VALUES (@DateAlerte,                
                                                               @IdentifiantPersonne)";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("DateAlerte", FormationPersonne.DateAlerte);
            commande.Parameters.AddWithValue("IdentifiantPersonne", FormationPersonne.personne);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(AlerteSenior FormationPersonne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE AlerteSenior
                               SET DateAlerte=@DateAlerte,              
                                   IdentifiantPersonne=@IdentifiantPersonne,
      
                               WHERE Identifiant=@Identifiant ;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Identifiant", FormationPersonne);
            commande.Parameters.AddWithValue("DateAlerte", FormationPersonne.DateAlerte);
            commande.Parameters.AddWithValue("IdentifiantPersonne", FormationPersonne.personne);

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
            String requete = @"DELETE AlerteSenior
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
