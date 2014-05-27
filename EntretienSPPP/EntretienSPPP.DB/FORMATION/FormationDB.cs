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
    public static class FormationDB
    {
        /// <summary>
        /// Récupère une liste de Formation à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Formation> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, Titre, Objectif, Interne, Externe FROM Formation ;";

            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Formation> list = new List<Formation>();
            while (dataReader.Read())
            {

                //1 - Créer un Formation à partir des donner de la ligne du dataReader
                Formation formation = new Formation();
                formation.Identifiant = dataReader.GetInt32(0);
                formation.Titre = dataReader.GetString(2);
                formation.Objectif = dataReader.GetString(3);
                formation.Interne = dataReader.GetChar(4);
                formation.Externe = dataReader.GetChar(5);


                //2 - Ajouter ce Formation à la list de client
                list.Add(formation);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Formation à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Formation</param>
        /// <returns>Un Formation </returns>
        public static Formation Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Titre, Objectif, Interne, Externe FROM Formation WHERE Identifiant = @Identifiant ;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Formation
            Formation formation = new Formation();

            formation.Identifiant = dataReader.GetInt32(0);
            dataReader.Close();
            connection.Close();
            return formation;
        }

         public static Boolean update(Formation formation)
        {
            Boolean isUpDAte = false ;
            //mettre a jour la base de donnée
            // retourne un boulean si l'update ses bien dérouler

            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"UPDATE Formation SET Titre = @Titre, Objectif = @Objectif, interne = @interne, externe = @externe WHERE Identifiant = @Identifiant  ;";
            
            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Titre", formation.Titre);
            commande.Parameters.AddWithValue("Objectif", formation.Objectif);
            commande.Parameters.AddWithValue("interne", formation.Interne);
            commande.Parameters.AddWithValue("externe", formation.Externe);
             commande.Parameters.AddWithValue("Identifiant", formation.Identifiant);

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

        public static Boolean delete(Formation formation)
        {
            Boolean isDelete = false;
            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"DELETE FROM Formation WHERE Identifiant = @Identifiant ;";

            SqlCommand commande = new SqlCommand(requete, connection);


            commande.Parameters.AddWithValue("Identifiant", formation.Identifiant);

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

        public static Formation Insert (Formation formation)
        {
            
            SqlConnection connection = DataBase.connection;
           


            String requete = @"Insert INTO formation(Titre,Objectif,Interne,Externe) Values (@organisme,@Titre,@Objectif,@Interne,@Externe); SELECT SCOPE_IDENTITY() ;";

            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Titre",formation.Titre);
            commande.Parameters.AddWithValue("Objectif",formation.Objectif);
            commande.Parameters.AddWithValue("Interne",formation.Interne);
            commande.Parameters.AddWithValue("Externe",formation.Externe);
            
           
              try
            {
                connection.Open();
                Decimal IDENTIFIANTDERNIERAJOUT = (Decimal)commande.ExecuteScalar();
                return FormationDB.Get(Int32.Parse(IDENTIFIANTDERNIERAJOUT.ToString()));
                
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

