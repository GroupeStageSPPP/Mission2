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
    public static class OrganismeDB
    {
        /// <summary>
        /// Récupère une liste de Organisme à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Organisme> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, Libelle, Telephone, Adresse FROM Organisme";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Organisme> list = new List<Organisme>();
            while (dataReader.Read())
            {

                //1 - Créer un Organisme à partir des donner de la ligne du dataReader
                Organisme organisme = new Organisme();
                organisme.Identifiant = dataReader.GetInt32(0);
                organisme.Libelle = dataReader.GetString(1);
                organisme.Telephone = dataReader.GetString(2);
                organisme.Adresse = dataReader.GetString(3);


                //2 - Ajouter ce Organisme à la list de client
                list.Add(organisme);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Organisme à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Organisme</param>
        /// <returns>Un Organisme </returns>
        public static Organisme Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Libelle, Telephone, Adresse FROM Organisme
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Organisme
            Organisme organisme = new Organisme();

            organisme.Identifiant = dataReader.GetInt32(0);
            organisme.Libelle = dataReader.GetString(1);
            organisme.Telephone = dataReader.GetString(2);
            organisme.Adresse = dataReader.GetString(3);
            dataReader.Close();
            connection.Close();
            return organisme;
        }

         public static void Insert(Organisme Organisme)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"INSERT INTO Organisme (Libelle, Telephone, Adresse)
                               VALUES (@Libelle, @Telephone, @Adresse); SELECT SCOPE_IDENTITY() ";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Libelle", Organisme.Libelle);
            commande.Parameters.AddWithValue("Telephone", Organisme.Telephone);
            commande.Parameters.AddWithValue("Adresse", Organisme.Adresse);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

         public static void Update(Organisme Organisme)
         {
             //Connection
             SqlConnection connection = DataBase.connection;
            
             //Commande
             String requete = @"INSERT INTO Organisme 
                                SET Libelle = @Libelle, Telephone = @Telephone, Adresse = @Adresse
                                WHERE Identifiant =  @Ientifiant";
             SqlCommand commande = new SqlCommand(requete, connection);

             //Paramètres
             commande.Parameters.AddWithValue("Libelle", Organisme.Libelle);
             commande.Parameters.AddWithValue("Telephone", Organisme.Telephone);
             commande.Parameters.AddWithValue("Adresse", Organisme.Adresse);
             commande.Parameters.AddWithValue("Identifiant", Organisme.Identifiant);
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
            String requete = @"DELETE FROM Organisme 
                               WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", Identifiant);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static Int32 LastID()
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = @"SELECT Identifiant FROM Organisme
                                WHERE Identifiant = (SELECT MAX(Identifiant) FROM Organisme); ";
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
