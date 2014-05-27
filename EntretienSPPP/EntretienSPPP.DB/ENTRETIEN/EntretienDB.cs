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
    public static class EntretienDB
    {
        /// <summary>
        /// Récupère une liste de Entretien à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Entretien> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, DateDeb, DateFin, Commentaire, IdentifiantPersonne, Expression, DefinitionFonction, ClareteFonction,ClareteObjectif FROM Entretien";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Entretien> list = new List<Entretien>();
            while (dataReader.Read())
            {

                //1 - Créer un Entretien à partir des donner de la ligne du dataReader
                Entretien entretien = new Entretien();
                entretien.Identifiant = dataReader.GetInt32(0);
                entretien.DateDeb = dataReader.GetDateTime(1);
                entretien.DateFin = dataReader.GetDateTime(2);
                entretien.Commentaire = dataReader.GetString(3);
                entretien.personne.Identifiant = dataReader.GetInt32(4);
                entretien.Expression = dataReader.GetChar(5);
                entretien.DefinitionFonction = dataReader.GetChar(6);
                entretien.ClareteObjectif = dataReader.GetChar(7);
                entretien.ClareteFonction = dataReader.GetChar(8);

                //2 - Ajouter ce Entretien à la list de client
                list.Add(entretien);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Entretien à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Entretien</param>
        /// <returns>Un Entretien </returns>
        public static Entretien Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, DateDeb, DateFin, Commentaire, IdentifiantPersonne, Expression, DefinitionFonction, ClareteFonction, ClareteObjectif FROM Entretien
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Entretien
            Entretien entretien = new Entretien();
            entretien.Identifiant = dataReader.GetInt32(0);
            entretien.DateDeb = dataReader.GetDateTime(1);
            entretien.DateFin = dataReader.GetDateTime(2);
            entretien.Commentaire = dataReader.GetString(3);
            entretien.personne.Identifiant = dataReader.GetInt32(4);
            entretien.Expression = dataReader.GetChar(5);
            entretien.DefinitionFonction = dataReader.GetChar(6);
            entretien.ClareteObjectif = dataReader.GetChar(7);
            entretien.ClareteFonction = dataReader.GetChar(8);
            dataReader.Close();
            connection.Close();
            return entretien;
        }

        public static void Insert(Entretien Entretien)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"INSERT INTO Entretien (DateDeb, DateFin, Commentaire, IdentifiantPersonne, Expression, DefinitionFonction, ClareteFonction, ClareteObjectif)
                                VALUES (@DateDeb, @DateFin, @Commentaire, @IdentifiantPersonne, @Expression, @DefinitionFonction, @ClareteFonction, @ClareteObjectif) ; SELECT SCOPE_IDENTITY() ";
            connection.Open();            
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("DateDeb", Entretien.DateDeb);
            commande.Parameters.AddWithValue("DateFin", Entretien.DateFin);
            commande.Parameters.AddWithValue("Commentaire", Entretien.Commentaire);
            commande.Parameters.AddWithValue("IdentifiantPersonne", Entretien.personne.Identifiant);
            commande.Parameters.AddWithValue("Expression", Entretien.Expression);
            commande.Parameters.AddWithValue("DefinitionFonction", Entretien.DefinitionFonction);
            commande.Parameters.AddWithValue("ClareteFonction", Entretien.ClareteFonction);
            commande.Parameters.AddWithValue("ClareteObjectif", Entretien.ClareteObjectif);
            //Execution

            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Entretien Entretien)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"UPDATE Entretien 
                               SET DateDeb = @DateDeb, DateFin = @DateFin, Commentaire = @Commentaire , IdentifiantPersonne = @IdentifiantPersonne , Expression = @Expression, DefinitionFonction = @DefinitionFonction, ClareteFonction = @ClareteFonction, ClareteObjectif = @ClareteObjectif
                               WHERE Identifiant = @Identifiant";
            connection.Open();            
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("DateDeb", Entretien.DateDeb);
            commande.Parameters.AddWithValue("DateFin", Entretien.DateFin);
            commande.Parameters.AddWithValue("Commentaire", Entretien.Commentaire);
            commande.Parameters.AddWithValue("IdentifiantPersonne", Entretien.personne.Identifiant);
            commande.Parameters.AddWithValue("Expression", Entretien.Expression);
            commande.Parameters.AddWithValue("DefinitionFonction", Entretien.DefinitionFonction);
            commande.Parameters.AddWithValue("ClareteFonction", Entretien.ClareteFonction);
            commande.Parameters.AddWithValue("ClareteObjectif", Entretien.ClareteObjectif);
            commande.Parameters.AddWithValue("Identifiant", Entretien.Identifiant);
            //Execution

            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(Int32 Identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"DELETE FROM Entretien 
                               WHERE Identifiant = @Identifiant";
            connection.Open();            
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", Identifiant);
            //Execution

            commande.ExecuteNonQuery();
            connection.Close();
        }
    }
}
