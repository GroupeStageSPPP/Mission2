using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB
{
    public static class FamilleDB
    {
        /// <summary>
        /// Récupère une liste de Famille à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Famille> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, Libelle FROM Famille ;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Famille> list = new List<Famille>();
            while (dataReader.Read())
            {

                //1 - Créer un Famille à partir des donner de la ligne du dataReader
                Famille famille = new Famille();
                famille.Identifiant = dataReader.GetInt32(0);
                famille.Libelle = dataReader.GetString(1);


                //2 - Ajouter ce Famille à la list de client
                list.Add(famille);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Famille à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Famille</param>
        /// <returns>Un Famille </returns>
        public static Famille Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Libelle FROM Famille
                                WHERE Identifiant = @Identifiant ;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Famille
            Famille famille = new Famille();

            famille.Identifiant = dataReader.GetInt32(0);
            famille.Libelle = dataReader.GetString(1);
            dataReader.Close();
            connection.Close();
            return famille;
        }

        public static Boolean Update(Famille famille)
        {
            Boolean isUpDAte = false;
            //mettre a jour la base de donnée
            // retourne un boulean si l'update ses bien dérouler

            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"Update famille set libelle = @libelle where identifiant = @identifiant  ;";

            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Libelle", famille.Libelle);
            commande.Parameters.AddWithValue("identifiant", famille);

            try
            {
                connection.Open();
                commande.ExecuteNonQuery();
                isUpDAte = true;
            }

            catch (Exception)
            {
                isUpDAte = false;
            }

            finally
            {
                connection.Close();
            }

            return isUpDAte;
        }

        public static Boolean Delete(Famille famille)
        {
            Boolean isDelete = false;
            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"DELETE FROM Famille WHERE Identifiant = @Identifiant ; ";

            SqlCommand commande = new SqlCommand(requete, connection);


            commande.Parameters.AddWithValue("Identifiant", famille);

            try
            {
                connection.Open();
                commande.ExecuteNonQuery();
                isDelete = true;
            }

            catch (Exception)
            {
                isDelete = false;
            }

            finally
            {
                connection.Close();
            }

            return isDelete;

      
        }

        public static Famille Insert(Famille famille)
        {
            
            SqlConnection connection = DataBase.connection;
           


            String requete = @"Insert INTO Famille(libelle) Values (@libelle) SELECT SCOPE_IDENTITY(); ";

            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("libelle",famille.Libelle);
            
           
              try
            {
                connection.Open();
                Decimal IDENTIFIANTDERNIERAJOUT = (Decimal)commande.ExecuteScalar();
                return FamilleDB.Get(Int32.Parse(IDENTIFIANTDERNIERAJOUT.ToString()));
                
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

           
            }

            
        }
    }

