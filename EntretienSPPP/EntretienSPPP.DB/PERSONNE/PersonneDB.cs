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
    public static class PersonneDB
    {
        /// <summary>
        /// Récupère une liste de Personne à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Personne> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = "SELECT Identifiant, Nom, Prenom, DateNaissance, Rue, Ville, CodePostal, IdentifiantGenre, IdentifiantFamille, Telephone, Mail FROM Personne";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Personne> list = new List<Personne>();
            while (dataReader.Read())
            {

                //1 - Créer un Personne à partir des donner de la ligne du dataReader
                Personne personne = new Personne();
                personne.Identifiant = dataReader.GetInt32(0);
                personne.Nom = dataReader.GetString(1);
                personne.Prenom = dataReader.GetString(2);
                personne.DateNaissance = dataReader.GetDateTime(3);
                personne.Rue = dataReader.GetString(4);
                personne.Ville = dataReader.GetString(5);
                personne.CodePostal = dataReader.GetString(6);
                personne.genre.Identifiant = dataReader.GetInt32(7);
                personne.famille.Identifiant = dataReader.GetInt32(8);
                personne.Telephone = dataReader.GetString(9);
                personne.Mail = dataReader.GetString(10);



                //2 - Ajouter ce Personne à la list de client
                list.Add(personne);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Personne à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Personne</param>
        /// <returns>Un Personne </returns>
        public static Personne Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"SELECT Identifiant, Nom, Prenom, DateNaissance, Rue, Ville, CodePostal, IdentifiantGenre, IdentifiantFamille, Telephone, Mail FROM Personne
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Personne
            Personne personne = new Personne();

            personne.Identifiant = dataReader.GetInt32(0);
            personne.Nom = dataReader.GetString(1);
            personne.Prenom = dataReader.GetString(2);
            personne.DateNaissance = dataReader.GetDateTime(3);
            personne.Rue = dataReader.GetString(4);
            personne.Ville = dataReader.GetString(5);
            personne.CodePostal = dataReader.GetString(6);
            personne.genre.Identifiant = dataReader.GetInt32(7);
            personne.famille.Identifiant = dataReader.GetInt32(8);
            personne.Telephone = dataReader.GetString(9);
            personne.Mail = dataReader.GetString(10);
            dataReader.Close();
            connection.Close();





            return personne;
        }

        public static void Insert(Personne Personne)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"INSERT INTO Personne (Nom, Prenom, DateNaissance, Ville, CodePostal, Telephone, Mail, IdentifiantFamille, IdentifiantGenre)
                               VALUES (@Nom, @Prenom, @DateNaissance, @Ville, @CodePostal, @Telephone, @Mail, @IdentifiantFamille, @IdentifiantGenre)";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Nom", Personne.Nom);
            commande.Parameters.AddWithValue("Prenom", Personne.Prenom);
            commande.Parameters.AddWithValue("DateNaissance", Personne.DateNaissance);
            commande.Parameters.AddWithValue("Rue", Personne.Rue);
            commande.Parameters.AddWithValue("Ville", Personne.Ville);
            commande.Parameters.AddWithValue("CodePostal", Personne.CodePostal);
            commande.Parameters.AddWithValue("Telephone", Personne.Telephone);
            commande.Parameters.AddWithValue("Mail", Personne.Mail);
            commande.Parameters.AddWithValue("IdentifiantFamille", Personne.famille.Identifiant);
            commande.Parameters.AddWithValue("IdentifiantGenre", Personne.genre.Identifiant);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Personne Personne)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"UPDATE Personne SET Nom = @Nom, Prenom = @Prenom, DateNaissance = @DateNaissance, Ville = @Ville, CodePostal = @CodePostal, Telephone = @Telephone, Mail = @Mail, IdentifiantFamille = @IdentifiantFamille, IdentifiantGenre = @IdentifiantGenre
                               WHERE ";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Nom", Personne.Nom);
            commande.Parameters.AddWithValue("Prenom", Personne.Prenom);
            commande.Parameters.AddWithValue("DateNaissance", Personne.DateNaissance);
            commande.Parameters.AddWithValue("Rue", Personne.Rue);
            commande.Parameters.AddWithValue("Ville", Personne.Ville);
            commande.Parameters.AddWithValue("CodePostal", Personne.CodePostal);
            commande.Parameters.AddWithValue("Telephone", Personne.Telephone);
            commande.Parameters.AddWithValue("Mail", Personne.Mail);
            commande.Parameters.AddWithValue("IdentifiantFamille", Personne.famille.Identifiant);
            commande.Parameters.AddWithValue("IdentifiantGenre", Personne.genre.Identifiant);
            commande.Parameters.AddWithValue("Identifiant", Personne.Identifiant);
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
            String requete = @"DELETE FROM Personne 
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
