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
    public static class PosteDB
    {
        /// <summary>
        /// Récupère une liste de Poste à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Poste> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = "SELECT Identifiant, Libelle, Fonction FROM Poste";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Poste> list = new List<Poste>();
            while (dataReader.Read())
            {

                //1 - Créer un Poste à partir des donner de la ligne du dataReader
                Poste poste = new Poste();
                poste.Identifiant = dataReader.GetInt32(0);
                poste.Libelle = dataReader.GetString(1);
                poste.Fonction = dataReader.GetString(2);


                //2 - Ajouter ce Poste à la list de client
                list.Add(poste);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Poste à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Poste</param>
        /// <returns>Un Poste </returns>
        public static Poste Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"SELECT Identifiant, Libelle, Fonction FROM Poste
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Poste
            Poste poste = new Poste();

            poste.Identifiant = dataReader.GetInt32(0);
            poste.Libelle = dataReader.GetString(1);
            poste.Fonction = dataReader.GetString(2);
            dataReader.Close();
            connection.Close();
            return poste;
        }

        public static void Insert(Poste Poste)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"INSERT INTO Poste (Libelle, Fonction)
                                VALUES (@Libelle, @Fonction)";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Libelle", Poste.Libelle);
            commande.Parameters.AddWithValue("Fonction", Poste.Fonction);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Poste Poste)
        {
            //Connection
            SqlConnection connection = DataBase.connection
           
            //Commande
            String requete = @"UPDATE Poste 
                               SET Libelle = @Libelle, Fonction = @Fonction
                               WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Libelle", Poste.Libelle);
            commande.Parameters.AddWithValue("Fonction", Poste.Fonction);
            commande.Parameters.AddWithValue("Identifiant", Poste.Identifiant);
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
            String requete = @"DELETE FROM Poste 
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
