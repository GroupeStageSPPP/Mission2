using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB
{
    public static class SouhaitFormationDB
    {
        /// <summary>
        /// Récupère une liste de SouhaitFormation à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<SouhaitFormation> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, Objectif, Interne, Externe, AvisPersonne, AvisResponsable, IdentifiantEntretien FROM SouhaitFormation;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<SouhaitFormation> list = new List<SouhaitFormation>();
            while (dataReader.Read())
            {

                //1 - Créer un SouhaitFormation à partir des donner de la ligne du dataReader


                SouhaitFormation souhaitFormation = new SouhaitFormation();
                souhaitFormation.Identifiant = dataReader.GetInt32(0);
                souhaitFormation.Objectif = dataReader.GetString(1);
                souhaitFormation.Interne = dataReader.GetChar(2);
                souhaitFormation.Externe = dataReader.GetChar(3); 
                souhaitFormation.AvisPersonne = dataReader.GetString(4);
                souhaitFormation.AvisResponsable = dataReader.GetString(5);
                souhaitFormation.entretien.Identifiant = dataReader.GetInt32(6);


                //2 - Ajouter ce SouhaitFormation à la list de client
                list.Add(souhaitFormation);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une SouhaitFormation à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de SouhaitFormation</param>
        /// <returns>Un SouhaitFormation </returns>
        public static SouhaitFormation Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Objectif, Interne, Externe, AvisPersonne, AvisResponsable, IdentifiantEntretien FROM SouhaitFormation
                                WHERE Identifiant = @Identifiant;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du SouhaitFormation

            SouhaitFormation souhaitFormation = new SouhaitFormation();

            souhaitFormation.Identifiant = dataReader.GetInt32(0);
            souhaitFormation.Objectif = dataReader.GetString(1);
            souhaitFormation.Interne = dataReader.GetChar(2);
            souhaitFormation.Externe = dataReader.GetChar(3); 
            souhaitFormation.AvisPersonne = dataReader.GetString(4);
            souhaitFormation.AvisResponsable = dataReader.GetString(5);
            souhaitFormation.entretien.Identifiant = dataReader.GetInt32(6);
            dataReader.Close();
            connection.Close();
            return souhaitFormation;
        }

        public static void Insert(SouhaitFormation SouhaitFormation)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"INSERT INTO SouhaitFormation (Objectif, Interne, Externe, AvisPersonne, AvisResponsable, IdentifiantEntretien)
                               VALUES (@Objectif, @Interne, @Externe, @AvisPersonne, @AvisResponsable, @IdentifiantEntretien) SELECT SCOPE_IDENTITY() ;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Objectif", SouhaitFormation.Objectif);
            commande.Parameters.AddWithValue("Interne", SouhaitFormation.Interne);
            commande.Parameters.AddWithValue("Externe", SouhaitFormation.Externe);
            commande.Parameters.AddWithValue("AvisPersonne", SouhaitFormation.AvisPersonne);
            commande.Parameters.AddWithValue("AvisResponsable", SouhaitFormation.AvisResponsable);
            commande.Parameters.AddWithValue("IdentifiantEntretien", SouhaitFormation.entretien.Identifiant);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(SouhaitFormation SouhaitFormation)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"UPDATE SouhaitFormation 
                               SET Objectif = @Objectif, Interne = @Interne, Externe = @Externe, AvisPersonne = @AvisPersonne, AvisResponsable = @AvisResponsable
                               WHERE Identifiant = @Identifiant;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Objectif", SouhaitFormation.Objectif);
            commande.Parameters.AddWithValue("Interne", SouhaitFormation.Interne);
            commande.Parameters.AddWithValue("Externe", SouhaitFormation.Externe);
            commande.Parameters.AddWithValue("AvisPersonne", SouhaitFormation.AvisPersonne);
            commande.Parameters.AddWithValue("AvisResponsable", SouhaitFormation.AvisResponsable);
            commande.Parameters.AddWithValue("Identifiant", SouhaitFormation.Identifiant);
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
            String requete = @"DELETE FROM SouhaitFormation 
                               WHERE Identifiant = @Identifiant;";
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
