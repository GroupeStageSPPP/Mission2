using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB
{
    public static class ContratDB
    {
        public static List<Contrat> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = "SELECT Identifiant, Libelle, IsEssai, IsFinCtr  FROM Contrat";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Contrat> list = new List<Contrat>();
            while (dataReader.Read())
            {

                //1 - Créer un Contrat à partir des donner de la ligne du dataReader
                Contrat contrat = new Contrat();
                contrat.Identifiant = dataReader.GetInt32(0);
                contrat.Libelle = dataReader.GetString(1);
                contrat.IsEssai = dataReader.GetByte(2);
                contrat.IsFinCtr = dataReader.GetByte(3);




                //2 - Ajouter ce Contrat à la list de client
                list.Add(contrat);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Contrat à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Contrat</param>
        /// <returns>Un Contrat </returns>
        public static Contrat Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = @"SELECT Identifiant, Libelle, IsEssai, IsFinCtr  Type FROM Contrat
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Contrat
            Contrat contrat = new Contrat();
            contrat.Identifiant = dataReader.GetInt32(0);
            contrat.Libelle = dataReader.GetString(1);
            contrat.IsEssai = dataReader.GetByte(2);
            contrat.IsFinCtr = dataReader.GetByte(3);
            dataReader.Close();
            connection.Close();
            return contrat;
        }

        public static void Insert(Contrat contrat)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"INSERT INTO Contrat ( Libelle, IsEssai, IsFinCtr)     
 
                                                       VALUES (@Libelle,                
                                                               @IsEssai,
                                                               @IsFinCtr)";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Libelle", contrat.Libelle);
            commande.Parameters.AddWithValue("IsEssai", contrat.IsEssai);
            commande.Parameters.AddWithValue("IsFinCtr", contrat.IsFinCtr);
            //Execution
            connection.Open();
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(Contrat contrat)
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Requete
            String requete = @"UPDATE Contrat
                               SET DateFin=@DateFin,              
                                   Identifiantcontrat=@contrat,
      
                               WHERE Identifiant=@Identifiant ;";

            //Commande
            SqlCommand commande = new SqlCommand(requete, connection);

            //Parametres
            commande.Parameters.AddWithValue("Libelle", contrat.Libelle);
            commande.Parameters.AddWithValue("IsEssai", contrat.IsEssai);
            commande.Parameters.AddWithValue("IsFinCtr", contrat.IsFinCtr);

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
            String requete = @"DELETE Contrat
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
