using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntretienSPPP.DB
{
    public static class NiveauDB
    {
        /// <summary>
        /// Récupère une liste de catégorie à partir de la color de données
        /// </summary>
        /// <returns>Une liste de catégorie</returns>
        public static List<Niveau> List()
        {

            SqlConnection connection = DataBase.connection;

            String requete = "SELECT Identifiant, Libelle FROM Niveau";

            connection.Open();

            SqlCommand commande = new SqlCommand(requete, connection);


            SqlDataReader dataReader = commande.ExecuteReader();

            List<Niveau> list = new List<Niveau>();

            while (dataReader.Read())
            {

                //1 - Créer un groupe à partir des donner de la ligne du dataReader
                Niveau categorie = new Niveau();
                categorie.Identifiant = dataReader.GetInt32(0);
                categorie.Libelle = dataReader.GetString(1);


                //2 - Ajouter cette civilité à la list de civilité
                list.Add(categorie);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une catégorie à partir d'un Identifiant de catégorie
        /// </summary>
        /// <param name="Identifiant">Identifant de catégorie</param>
        /// <returns>Une catégorie</returns>
        public static Niveau Get(Int32 Identifiant)
        {

            SqlConnection connection = DataBase.connection;

            String requete = @"SELECT Identifiant, Libelle FROM Niveau
                                WHERE Identifiant=@Identifiant";

            SqlCommand commande = new SqlCommand(requete, connection);


            commande.Parameters.AddWithValue("Identifiant", Identifiant);


            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();
            dataReader.Read();

            //1 - Création de la civilite
            Niveau categorie = new Niveau();

            categorie.Identifiant = dataReader.GetInt32(0);
            categorie.Libelle = dataReader.GetString(1);

            dataReader.Close();
            connection.Close();

            return categorie;
        }





        public static void Insert(Niveau categorie)
        {

            SqlConnection connection = DataBase.connection;

            String requete = @"INSERT INTO Niveau(Libelle) VALUES(@Libelle)";
            connection.Open();

            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Libelle", categorie.Libelle);


            commande.ExecuteNonQuery();

            connection.Close();
        }

        public static void Update(Niveau categorie)
        {

            SqlConnection connection = DataBase.connection;

            String requete = @"UPDATE Niveau  
                               SETLibelle=@Libelle  
                               WHERE Identifiant=@Identifiant;";

            connection.Open();


            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Identifiant", categorie.Identifiant);
            commande.Parameters.AddWithValue("Libelle", categorie.Libelle);

            commande.ExecuteNonQuery();

            connection.Close();
        }

        public static void Delete(Int32 Identifiant)
        {

            SqlConnection connection = DataBase.connection;


            String requete = @"DELETE FROM Niveau 
                               WHERE Identifiant=@Identifiant";

            connection.Open();


            SqlCommand commande = new SqlCommand(requete, connection);


            commande.Parameters.AddWithValue("Identifiant", Identifiant);

            commande.ExecuteNonQuery();

            connection.Close();
        }
    }
}
