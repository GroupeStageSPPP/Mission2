using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntretienSPPP.DB
{
    public static class DiplomeDB
    {
        /// <summary>
        /// Récupère une liste de Diplome à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Diplome> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, Libelle, IdentifiantNiveau FROM Diplome";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Diplome> list = new List<Diplome>();
            while (dataReader.Read())
            {

                //1 - Créer un Diplome à partir des donner de la ligne du dataReader
                Diplome diplome = new Diplome();
                diplome.Identifiant = dataReader.GetInt32(0);
                diplome.Libelle = dataReader.GetString(1);
                diplome.Niveau = dataReader.GetInt32(2);


                //2 - Ajouter ce Diplome à la list de client
                list.Add(diplome);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Diplome à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Diplome</param>
        /// <returns>Un Diplome </returns>
        public static Diplome Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Libelle, IdentifiantNiveau FROM Diplome
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Diplome
            Diplome diplome = new Diplome();

            diplome.Identifiant = dataReader.GetInt32(0);
            diplome.Libelle = dataReader.GetString(1);
            diplome.Niveau = dataReader.GetInt32(2);
            dataReader.Close();
            connection.Close();
            return diplome;
        }

        public static void Insert(Diplome Diplome)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"INSERT INTO Diplome (Libelle, IdentifiantNiveau)
                                VALUES (@Libelle, @IdentifiantNiveau);SELECT SCOPE_IDENTITY() ";
            connection.Open();            
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Libelle", Diplome.Libelle);
            commande.Parameters.AddWithValue("IdentifiantNiveau", Diplome.Niveau);
            //Execution


            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Diplome Diplome)
        {


            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"UPDATE Diplome
                               SET Libelle = @Libelle, IdentifiantNiveau = @IdentifiantNiveau
                               WHERE Identifiant = @Identifiant";
            connection.Open();            
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Libelle", Diplome.Libelle);
            commande.Parameters.AddWithValue("niveau", Diplome.Niveau);
            //Execution

            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(Int32 Identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"DELETE FROM Diplome 
                               WHERE Identifiant = @Identifiant";
            connection.Open();            
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", Identifiant);
            //Execution

            commande.ExecuteNonQuery();
            connection.Close();
        }
        public static Int32 LastID()
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = @"SELECT Identifiant FROM Diplome
                                WHERE Identifiant = (SELECT MAX(Identifiant) FROM Diplome); ";
            SqlCommand commande = new SqlCommand(requete, connection);


            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            Int32 LastID = dataReader.GetInt32(0);

            dataReader.Close();
            connection.Close();
            return LastID;

        }
    }
}
