using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EntretienSPPP.DB
{
    public static class CVDB
    {
        /// <summary>
        /// Récupère une liste de CV à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<CV> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = "SELECT Identifiant, DateDeb, DateFin, Entreprise, IdentifiantPersonne FROM CV";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<CV> list = new List<CV>();
            while (dataReader.Read())
            {

                //1 - Créer un CV à partir des donner de la ligne du dataReader
                CV cv = new CV();
                cv.Identifiant = dataReader.GetInt32(0);
                cv.DateDeb = dataReader.GetDateTime(1);
                cv.DateFin = dataReader.GetDateTime(2);
                cv.Entreprise = dataReader.GetString(3);
                cv.personne.Identifiant = dataReader.GetInt32(4);

                //2 - Ajouter ce CV à la list de client
                list.Add(cv);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une CV à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de CV</param>
        /// <returns>Un CV </returns>
        public static CV Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"SELECT Identifiant, DateDeb, DateFin, Entreprise, Secteur, Poste, IdentifiantPersonne FROM CV
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du CV
            CV cv = new CV();

            cv.Identifiant = dataReader.GetInt32(0);
            cv.DateDeb = dataReader.GetDateTime(1);
            cv.DateFin = dataReader.GetDateTime(2);
            cv.Entreprise = dataReader.GetString(3);
            cv.Secteur = dataReader.GetString(4);
            cv.Poste = dataReader.GetString(5);
            cv.personne.Identifiant = dataReader.GetInt32(6);
            dataReader.Close();
            connection.Close();
            return cv;
        }

        public static void Insert(CV Cv)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"INSERT INTO CV  (DateDeb, DateFin, Entreprise, Secteur, Poste, IdentifiantPersonne)
                               VALUES (@DateDeb, @DateFin, @Entreprise, @Secteur, @Poste, @IdentifiantPersonne)";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("DateDeb", Cv.DateDeb);
            commande.Parameters.AddWithValue("DateFin", Cv.DateFin);
            commande.Parameters.AddWithValue("Entreprise", Cv.Entreprise);
            commande.Parameters.AddWithValue("Secteur", Cv.Secteur);
            commande.Parameters.AddWithValue("Poste", Cv.Poste);
            commande.Parameters.AddWithValue("IdentifiantPersonne", Cv.personne.Identifiant);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(CV Cv)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"UPDATE CV  
                               SET DateDeb = @DateDeb, DateFin = @DateFin,  Entreprise = @Entreprise,  Secteur = @Secteur,  Poste @Poste= ,  IdentifiantPersonne =  @IdentifiantPersonne
                               WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("DateDeb", Cv.DateDeb);
            commande.Parameters.AddWithValue("DateFin", Cv.DateFin);
            commande.Parameters.AddWithValue("Entreprise", Cv.Entreprise);
            commande.Parameters.AddWithValue("Secteur", Cv.Secteur);
            commande.Parameters.AddWithValue("Poste", Cv.Poste);
            commande.Parameters.AddWithValue("IdentifiantPersonne", Cv.personne.Identifiant);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(Int32 Identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"DELETE FROM CV 
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
