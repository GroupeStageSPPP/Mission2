using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntretienSPPP.DB
{
    public static class Diplome_PersonneDB
    {
        /// <summary>
        /// Récupère une liste de Diplome_Personne à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Diplome_Personne> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, DateObtention, IdentifiantDiplome, IdentifiantPersonne FROM Diplome_Personne";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Diplome_Personne> list = new List<Diplome_Personne>();
            while (dataReader.Read())
            {

                //1 - Créer un Diplome_Personne à partir des données de la ligne du dataReader
                Diplome_Personne diplomePersonne = new Diplome_Personne();
                diplomePersonne.Identifiant = dataReader.GetInt32(0);
                diplomePersonne.DateObtention = dataReader.GetDateTime(1);
                diplomePersonne.diplome = dataReader.GetInt32(2);
                diplomePersonne.personne = dataReader.GetInt32(3);


                //2 - Ajouter ce Diplome_Personne à la list de client
                list.Add(diplomePersonne);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère la liste des diplomes d'une personne à partir de la base de données
        /// </summary>
        /// <returns>Une liste de Diplome</returns>
        public static List<Diplome> ListDiplome(Int32 IdentifiantPersonne )
        {
            List<Diplome> ListDiplome = new List<Diplome>();
            return ListDiplome;
        }

        /// <summary>
        /// Récupère une Diplome_Personne à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Diplome_Personne</param>
        /// <returns>Un Diplome_Personne </returns>
        public static Diplome_Personne Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, DateObtention, IdentifiantDiplome, IdentifiantPersonne FROM Diplome_Personne
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Diplome_Personne
            Diplome_Personne diplomePersonne = new Diplome_Personne();

            diplomePersonne.Identifiant = dataReader.GetInt32(0);
            diplomePersonne.DateObtention = dataReader.GetDateTime(1);
            diplomePersonne.diplome = dataReader.GetInt32(2);
            diplomePersonne.personne = dataReader.GetInt32(3);
            dataReader.Close();
            connection.Close();
            return diplomePersonne;
        }

        public static void Insert(Diplome_Personne Diplome_Personne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO Diplome_Personne (DateObtention, IdentifiantDiplome, IdentifiantPersonne)
                               VALUES (@DateObtention, @IdentifiantDiplome, @IdentifiantPersonne) 
                               SELECT SCOPE_IDENTITY() ";

            connection.Open();
            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("DateObtention", Diplome_Personne.DateObtention);
            commande.Parameters.AddWithValue("IdentifiantDiplome", Diplome_Personne.diplome);
            commande.Parameters.AddWithValue("IdentifiantPersonne", Diplome_Personne.personne);
            
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Diplome_Personne Diplome_Personne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE Diplome_Personne
                               SET DateObtention=@DateObtention, IdentifiantDiplome=@IdentifiantDiplome, IdentifiantPersonne=@IdentifiantPersonne
                               WHERE Identifiant=@Identifiant ";

            connection.Open();
            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Identifiant", Diplome_Personne);
            commande.Parameters.AddWithValue("DateObtention", Diplome_Personne.DateObtention);
            commande.Parameters.AddWithValue("IdentifiantDiplome", Diplome_Personne.diplome);
            commande.Parameters.AddWithValue("IdentifiantPersonne", Diplome_Personne.personne);            
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(Int32 Identifiant)
        { 
                        //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"DELETE Diplome_Personne
                               WHERE Identifiant=@Identifiant ";

            connection.Open();
            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Identifiant", Identifiant);
            
            commande.ExecuteNonQuery();
            connection.Close();
        }
    }
}
