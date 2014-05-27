using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EntretienSPPP.DB
{
    public static class Poste_PersonneDB
    {
        /// <summary>
        /// Récupère une liste de Poste_Personne à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Poste_Personne> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, DateDebut, DateFin, Statut, Coefficient, IdentifiantPersonne, IdentifiantPoste,Contrat, IdentiifiantSite FROM Poste_Personne;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Poste_Personne> list = new List<Poste_Personne>();
            while (dataReader.Read())
            {

                //1 - Créer un Poste_Personne à partir des donner de la ligne du dataReader
                Poste_Personne postePersonne = new Poste_Personne();
                postePersonne.Identifiant = dataReader.GetInt32(0);
                postePersonne.DateDebut = dataReader.GetDateTime(1);
                postePersonne.DateFin = dataReader.GetDateTime(2);
                postePersonne.Statut = dataReader.GetString(3);
                postePersonne.Coefficient = dataReader.GetInt32(4);
                postePersonne.personne = dataReader.GetInt32(5);
                postePersonne.poste = dataReader.GetInt32(6);
                postePersonne.Contrat = dataReader.GetString(7);
                postePersonne.site = dataReader.GetInt32(8);


                //2 - Ajouter ce Poste_Personne à la list de client
                list.Add(postePersonne);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Poste_Personne à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Poste_Personne</param>
        /// <returns>Un Poste_Personne </returns>
        public static Poste_Personne Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, DateDebut, DateFin, Statut, Coefficient, IdentifiantPersonne, IdentifiantPoste,Contrat, IdentifiantSite FROM Poste_Personne
                                WHERE Identifiant = @Identifiant;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Poste_Personne
            Poste_Personne postePersonne = new Poste_Personne();

            postePersonne.Identifiant = dataReader.GetInt32(0);
            postePersonne.DateDebut = dataReader.GetDateTime(1);
            postePersonne.DateFin = dataReader.GetDateTime(2);
            postePersonne.Statut = dataReader.GetString(3);
            postePersonne.Coefficient = dataReader.GetInt32(4);
            postePersonne.personne = dataReader.GetInt32(5);
            postePersonne.poste = dataReader.GetInt32(6);
            postePersonne.Contrat = dataReader.GetString(7);
            postePersonne.site = dataReader.GetInt32(8);
            dataReader.Close();
            connection.Close();
            return postePersonne;
        }

        public static void Insert(Poste_Personne Poste_Personne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO Poste_Personne (DateDebut, DateFin, Statut, Coefficient, IdentifiantPersonne, IdentifiantPoste,Contrat, IdentifiantSite)
                               VALUES (@DateDebut, @DateFin, @Site, @Statut, @Coefficient, @IdentifiantPersonne, @IdentifiantPoste, @Contrat, @IdentifiantSite) 
                               SELECT SCOPE_IDENTITY() ;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("DateDebut", Poste_Personne.DateDebut);
            commande.Parameters.AddWithValue("DateFin", Poste_Personne.DateFin);
            commande.Parameters.AddWithValue("Statut", Poste_Personne.Statut );
            commande.Parameters.AddWithValue("Coefficient", Poste_Personne.Coefficient);
            commande.Parameters.AddWithValue("IdentifiantPersonne", Poste_Personne.personne);
            commande.Parameters.AddWithValue("IdentifiantPoste", Poste_Personne.poste);
            commande.Parameters.AddWithValue("Contrat", Poste_Personne.Contrat);
            commande.Parameters.AddWithValue("IdentifiantSite", Poste_Personne.site);

            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Poste_Personne Poste_Personne)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE Poste_Personne
                               SET DateDebut=@DateDebut,
                                   DateFin=@DateFin, 
                                   Statut=@Statut, 
                                   Coefficient=@Coefficient, 
                                   IdentifiantPersonne=@IdentifiantPersonne,
                                   IdentifiantPoste=@IdentifiantPoste,
                                   Contrat=@Contrat,
                                   IdentifiantSite=@IdentifiantSite,
                             WHERE Identifiant=@Identifiant ;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("DateDebut", Poste_Personne.DateDebut);
            commande.Parameters.AddWithValue("DateFin", Poste_Personne.DateFin);
            commande.Parameters.AddWithValue("Statut", Poste_Personne.Statut);
            commande.Parameters.AddWithValue("Coefficient", Poste_Personne.Coefficient);
            commande.Parameters.AddWithValue("IdentifiantPersonne", Poste_Personne.personne);
            commande.Parameters.AddWithValue("IdentifiantPoste", Poste_Personne.poste);
            commande.Parameters.AddWithValue("Contrat", Poste_Personne.Contrat);
            commande.Parameters.AddWithValue("IdentifiantSite", Poste_Personne.site);
            commande.Parameters.AddWithValue("Identifiant", Poste_Personne);
 

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
            String requete = @"DELETE Poste_Personne
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
