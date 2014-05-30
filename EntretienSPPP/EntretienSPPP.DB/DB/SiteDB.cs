using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EntretienSPPP.DB
{
    public static class SiteDB
    {
        /// <summary>
        /// Récupère une liste de Site à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Site> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, Libelle, Rue, Ville, CodePostal FROM Site";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Site> list = new List<Site>();
            while (dataReader.Read())
            {

                //1 - Créer un Site à partir des donner de la ligne du dataReader
                Site site = new Site();
                site.Identifiant = dataReader.GetInt32(0);
                site.Libelle = dataReader.GetString(1);
                site.Rue = dataReader.GetString(2);
                site.Ville = dataReader.GetString(3);
                site.CodePostal = dataReader.GetString(4);


                //2 - Ajouter ce Site à la list de client
                list.Add(site);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Site à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Site</param>
        /// <returns>Un Site </returns>
        public static Site Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Libelle, Rue, Ville, CodePostal FROM Site
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Site
            Site site = new Site();

            site.Identifiant = dataReader.GetInt32(0);
            site.Libelle = dataReader.GetString(1);
            site.Rue = dataReader.GetString(2);
            site.Ville = dataReader.GetString(3);
            site.CodePostal = dataReader.GetString(4);

            dataReader.Close();
            connection.Close();
            return site;
        }

        public static void Insert(Site Site)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"INSERT INTO Site (Libelle, Rue, Ville, CodePostal)
                                VALUES (@Libelle, @Rue, @Ville, @CodePostal) ; SELECT SCOPE_IDENTITY();";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Libelle", Site.Libelle);
            commande.Parameters.AddWithValue("Rue", Site.Rue);
            commande.Parameters.AddWithValue("Ville", Site.Ville);
            commande.Parameters.AddWithValue("CodePostal", Site.CodePostal);
            
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Site Site)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"UPDATE Site 
                               SET Libelle = @Libelle, Rue = @Rue, Ville = @Ville, CodePostal = @CodePostal
                               WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Libelle", Site.Libelle);
            commande.Parameters.AddWithValue("Rue", Site.Rue);
            commande.Parameters.AddWithValue("Ville", Site.Ville);
            commande.Parameters.AddWithValue("CodePostal", Site.CodePostal);
            commande.Parameters.AddWithValue("Identifiant", Site.Identifiant);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(Int32 Identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"DELETE FROM Site 
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
