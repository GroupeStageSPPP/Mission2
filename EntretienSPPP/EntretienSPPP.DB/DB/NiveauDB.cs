using System;
using System.Collections.Generic;

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
                Niveau niveau = new Niveau();
                niveau.Identifiant = dataReader.GetInt32(0);
                niveau.Libelle = dataReader.GetString(1);


                //2 - Ajouter cette civilité à la list de civilité
                list.Add(niveau);
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
            Niveau niveau = new Niveau();

            niveau.Identifiant = dataReader.GetInt32(0);
            niveau.Libelle = dataReader.GetString(1);

            dataReader.Close();
            connection.Close();

            return niveau;
        }





        public static void Insert(Niveau niveau)
        {

            SqlConnection connection = DataBase.connection;

            String requete = @"INSERT INTO Niveau(Libelle) VALUES(@Libelle); SELECT SCOPE_IDENTITY() ";
            connection.Open();

            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Libelle", niveau.Libelle);


            commande.ExecuteNonQuery();

            connection.Close();
        }

        public static void Update(Niveau niveau)
        {

            SqlConnection connection = DataBase.connection;

            String requete = @"UPDATE Niveau  
                               SETLibelle=@Libelle  
                               WHERE Identifiant=@Identifiant;";

            connection.Open();


            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Identifiant", niveau);
            commande.Parameters.AddWithValue("Libelle", niveau.Libelle);

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

        public static Int32 LastID()
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = @"SELECT Identifiant FROM Niveau
                                WHERE Identifiant = (SELECT MAX(Identifiant) FROM Niveau); ";
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
