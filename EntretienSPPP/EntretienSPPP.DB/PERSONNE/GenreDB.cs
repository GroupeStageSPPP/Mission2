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
    public static class GenreDB
    {
        /// <summary>
        /// Récupère une liste de Genre à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Genre> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, Libelle FROM Genre ;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Genre> list = new List<Genre>();
            while (dataReader.Read())
            {

                //1 - Créer un Genre à partir des donner de la ligne du dataReader
                Genre genre = new Genre();
                genre.Identifiant = dataReader.GetInt32(0);
                genre.libelle = dataReader.GetString(1);


                //2 - Ajouter ce Genre à la list de client
                list.Add(genre);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Genre à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Genre</param>
        /// <returns>Un Genre </returns>
        public static Genre Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Libelle FROM Genre
                                WHERE Identifiant = @Identifiant ;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Genre
            Genre genre = new Genre();

            genre.Identifiant = dataReader.GetInt32(0);
            genre.libelle = dataReader.GetString(1);
            dataReader.Close();
            connection.Close();
            return genre;
        }

        public static Boolean Update(Genre genre)
        {
            Boolean isUpDAte = false ;
            //mettre a jour la base de donnée
            // retourne un boulean si l'update ses bien dérouler

            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"Update genre set libelle = @libelle where identifiant = @identifiant  ;";
            
            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Libelle", genre.libelle);
            commande.Parameters.AddWithValue("identifiant", genre.Identifiant);

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

        public static Boolean Delete(Genre genre)
        {
            Boolean isDelete = false;
            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"DELETE FROM genre WHERE Identifiant = @Identifiant ; ";

            SqlCommand commande = new SqlCommand(requete, connection);


            commande.Parameters.AddWithValue("Identifiant", genre.Identifiant);

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

        public static Genre Insert (Genre genre)
        {
            
            SqlConnection connection = DataBase.connection;
           


            String requete = @"Insert INTO genre(libelle) Values (@libelle) SELECT SCOPE_IDENTITY() ; ";

            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("libelle",genre.libelle);
            
           
              try
            {
                connection.Open();
                Decimal IDENTIFIANTDERNIERAJOUT = (Decimal)commande.ExecuteScalar();
                return GenreDB.Get(Int32.Parse(IDENTIFIANTDERNIERAJOUT.ToString()));
                
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

