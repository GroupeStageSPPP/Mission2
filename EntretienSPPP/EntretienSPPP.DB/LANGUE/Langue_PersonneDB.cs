using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntretienSPPP.DB
{
    public static class Langue_PersonneDB
    {
        /// <summary>
        /// Récupère une liste de Langue_Personne à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Langue_Personne> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection; ;
            //Commande
            String requete = "SELECT Identifiant, Niveau, Utilite,  IdentifiantPersonne, IdentifiantLangue FROM Langue_Personne";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Langue_Personne> list = new List<Langue_Personne>();
            while (dataReader.Read())
            {

                //1 - Créer un Langue_Personne à partir des donner de la ligne du dataReader
                Langue_Personne languePersonne = new Langue_Personne();
                languePersonne.Identifiant = dataReader.GetInt32(0);
                languePersonne.Niveau = dataReader.GetString(1);
                languePersonne.Utilite = dataReader.GetChar(2);
                languePersonne.personne.Identifiant = dataReader.GetInt32(3);
                languePersonne.langue.Identifiant = dataReader.GetInt32(4);



                //2 - Ajouter ce Langue_Personne à la list de client
                list.Add(languePersonne);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Langue_Personne à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Langue_Personne</param>
        /// <returns>Un Langue_Personne </returns>
        public static Langue_Personne Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection; ;

            //Commande
            String requete = @"SELECT Identifiant, Niveau, Utilite,  IdentifiantPersonne, IdentifiantLangue FROM Langue_Personne
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Langue_Personne
            Langue_Personne languePersonne = new Langue_Personne();
            languePersonne.Identifiant = dataReader.GetInt32(0);
            languePersonne.Niveau = dataReader.GetString(1);
            languePersonne.Utilite = dataReader.GetChar(2);
            languePersonne.personne.Identifiant = dataReader.GetInt32(3);
            languePersonne.langue.Identifiant = dataReader.GetInt32(4);

            dataReader.Close();
            connection.Close();
            return languePersonne;
        }

        public static void Insert(Langue_Personne Langue_Personne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO Langue_Personne (Niveau, 
                                                            Utilite,
                                                            IdentifiantPersonne, 
                                                            IdentifiantLangue)
                                                   VALUES (@Niveau, 
                                                           @Utilite,
                                                           @IdentifiantPersonne, 
                                                           @IdentifiantLangue)
                               SELECT SCOPE_IdentifiantENTITY() ;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Niveau", Langue_Personne.Niveau);
            commande.Parameters.AddWithValue("Utilite", Langue_Personne.Utilite);
            commande.Parameters.AddWithValue("IdentifiantPersonne", Langue_Personne.personne.Identifiant);
            commande.Parameters.AddWithValue("IdentifiantLangue", Langue_Personne.langue.Identifiant);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Langue_Personne Langue_Personne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE Langue_Personne
                               SET Niveau=@Niveau,
                                   Utilite=@Utilitee,
                                   IdentifiantPersonne=@IdentifiantPersonne;
                                   IdentifiantLangue=@IdentifiantLangue;

                               WHERE Identifiant=@Identifiant ;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Niveau", Langue_Personne.Niveau);
            commande.Parameters.AddWithValue("Utilite", Langue_Personne.Utilite);
            commande.Parameters.AddWithValue("IdentifiantPersonne", Langue_Personne.personne.Identifiant);
            commande.Parameters.AddWithValue("IdentifiantLangue", Langue_Personne.langue.Identifiant);

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
            String requete = @"DELETE Langue_Personne
                               WHERE Identifiant=@Identifiant ;";


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
