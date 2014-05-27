using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntretienSPPP.DB
{
    public static class Competence_PersonneDB
    {
        /// <summary>
        /// Récupère une liste de Competence_Personne à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Competence_Personne> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;;
            //Commande
            String requete = "SELECT Identifiant,  IdentifiantPersonne, IdentifiantCompetence FROM Competence_Personne";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Competence_Personne> list = new List<Competence_Personne>();
            while (dataReader.Read())
            {

                //1 - Créer un Competence_Personne à partir des donner de la ligne du dataReader
                Competence_Personne competencePersonne = new Competence_Personne();
                competencePersonne.Identifiant = dataReader.GetInt32(0);
                competencePersonne.personne = dataReader.GetInt32(1);
                competencePersonne.competence = dataReader.GetInt32(2);



                //2 - Ajouter ce Competence_Personne à la list de client
                list.Add(competencePersonne);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Competence_Personne à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Competence_Personne</param>
        /// <returns>Un Competence_Personne </returns>
        public static Competence_Personne Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;;
           
            //Commande
            String requete = @"SELECT Identifiant, IdentifiantPersonne, IdentifiantCompetence FROM Competence_Personne
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Competence_Personne
            Competence_Personne competencePersonne = new Competence_Personne();

            competencePersonne.Identifiant = dataReader.GetInt32(0);
            competencePersonne.personne = dataReader.GetInt32(1);
            competencePersonne.competence = dataReader.GetInt32(2);
            dataReader.Close();
            connection.Close();
            return competencePersonne;
        }

        public static void Insert(Competence_Personne Competence_Personne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO Competence_Personne (IdentifiantPersonne, 
                                                                IdentifiantCompetence)
                                                       VALUES (@IdentifiantPersonne, 
                                                               @IdentifiantCompetence)
                               SELECT SCOPE_IdentifiantENTITY() ;"; 

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("IdentifiantPersonne", Competence_Personne.personne);
            commande.Parameters.AddWithValue("IdentifiantCompetence", Competence_Personne.competence);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Competence_Personne Competence_Personne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE Competence_Personne
                               SET IdentifiantPersonne=@IdentifiantPersonne;
                                   IdentifiantCompetence=@IdentifiantCompetence;
                               WHERE Identifiant=@Identifiant ;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("IdentifiantPersonne", Competence_Personne.personne);
            commande.Parameters.AddWithValue("IdentifiantCompetence", Competence_Personne.competence);
            
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
            String requete = @"DELETE Competence_Personne
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
