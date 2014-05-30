using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB
{
    public static class AlerteHabilitationDB
    {
        /// <summary>
        /// Récupère une liste de AlerteHabilitation à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<AlerteHabilitation> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = "SELECT Identifiant, DateAlerte, IdentifiantHabilitationPersonne  FROM AlerteHabilitation;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<AlerteHabilitation> list = new List<AlerteHabilitation>();
            while (dataReader.Read())
            {

                //1 - Créer un AlerteHabilitation à partir des donner de la ligne du dataReader
                AlerteHabilitation alerteHabilitation = new AlerteHabilitation();
                alerteHabilitation.Identifiant = dataReader.GetInt32(0);
                alerteHabilitation.DateAlerte = dataReader.GetDateTime(1);
                alerteHabilitation.habilitationPersonne = dataReader.GetInt32(2);



                //2 - Ajouter ce AlerteHabilitation à la list de client
                list.Add(alerteHabilitation);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une AlerteHabilitation à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de AlerteHabilitation</param>
        /// <returns>Un AlerteHabilitation </returns>
        public static AlerteHabilitation Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = @"SELECT Identifiant, DateAlerte, IdentifiantHabilitationPersonne, Type FROM AlerteHabilitation
                                WHERE Identifiant = @Identifiant;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du AlerteHabilitation
            AlerteHabilitation alerteHabilitation = new AlerteHabilitation();

            alerteHabilitation.Identifiant = dataReader.GetInt32(0);
            alerteHabilitation.DateAlerte = dataReader.GetDateTime(1);
            alerteHabilitation.habilitationPersonne = dataReader.GetInt32(2);
            dataReader.Close();
            connection.Close();
            return alerteHabilitation;
        }

        public static void Insert(AlerteHabilitation FormationPersonne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO AlerteHabilitation ( DateAlerte, IdentifiantHabilitationPersonne)     
 
                                                       VALUES (@DateAlerte,                
                                                               @IdentifiantContrat);";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("DateAlerte", FormationPersonne.DateAlerte);
            commande.Parameters.AddWithValue("contrat", FormationPersonne.habilitationPersonne);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(AlerteHabilitation FormationPersonne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE AlerteHabilitation
                               SET DateAlerte=@DateAlerte,              
                                   IdentifiantHabilitationPersonne=@habilitationPersonne,
      
                               WHERE Identifiant=@Identifiant;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Identifiant", FormationPersonne);
            commande.Parameters.AddWithValue("DateAlerte", FormationPersonne.DateAlerte);
            commande.Parameters.AddWithValue("habilitationPersonne", FormationPersonne.habilitationPersonne);

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
            String requete = @"DELETE AlerteHabilitation
                               WHERE Identifiant=@Identifiant;";


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
