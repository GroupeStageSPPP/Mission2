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
    public static class InaptitudeDB
    {
        /// <summary>
        /// Récupère une liste de Inaptitude à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Inaptitude> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, Descriptif FROM Inaptitude ;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Inaptitude> list = new List<Inaptitude>();
            while (dataReader.Read())
            {

                //1 - Créer un Inaptitude à partir des donner de la ligne du dataReader
                Inaptitude inaptitude = new Inaptitude();
                inaptitude.Identifiant = dataReader.GetInt32(0);
                inaptitude.Descriptif = dataReader.GetString(1);


                //2 - Ajouter ce Inaptitude à la list de client
                list.Add(inaptitude);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Inaptitude à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Inaptitude</param>
        /// <returns>Un Inaptitude </returns>
        public static Inaptitude Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Descriptif FROM Inaptitude
                                WHERE Identifiant = @Identifiant ;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Inaptitude
            Inaptitude inaptitude = new Inaptitude();

            inaptitude.Identifiant = dataReader.GetInt32(0);
            inaptitude.Descriptif = dataReader.GetString(1);
            dataReader.Close();
            connection.Close();
            return inaptitude;
        }
        public static Boolean update(Inaptitude inaptitude)
        {
            Boolean isUpDAte = false ;
            //mettre a jour la base de donnée
            // retourne un boulean si l'update ses bien dérouler

            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"Update Inaptitude set Descriptif = @Descriptif where identifiant = @identifiant  ;";
            
            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Descriptif", inaptitude.Descriptif);
            commande.Parameters.AddWithValue("identifiant", inaptitude.Identifiant);

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

        public static Boolean delete(Inaptitude inaptitude)
        {
            Boolean isDelete = false;
            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"DELETE FROM Inaptitude WHERE Identifiant = @Identifiant ; ";

            SqlCommand commande = new SqlCommand(requete, connection);


            commande.Parameters.AddWithValue("Identifiant", inaptitude.Identifiant);

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

        public static Inaptitude CreateInaptitude(Inaptitude inaptitude)
        {

            SqlConnection connection = DataBase.connection;
           


            String requete = @"Insert INTO Inaptitude(Descriptif) Values (@Descriptif); SELECT SCOPE_IDENTITY() ; ";

            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("libelle", inaptitude.Descriptif);
            
           
              try
            {
                connection.Open();
                Decimal IDENTIFIANTDERNIERAJOUT = (Decimal)commande.ExecuteScalar();
                return InaptitudeDB.Get(Int32.Parse(IDENTIFIANTDERNIERAJOUT.ToString()));
                
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

        public static Int32 LastID()
        {
            //Connection
            SqlConnection connection = DataBase.connection;

            //Commande
            String requete = @"SELECT Identifiant FROM Inaptitude
                                WHERE Identifiant = (SELECT MAX(Identifiant) FROM Inaptitude); ";
            SqlCommand commande = new SqlCommand(requete, connection);


            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            Int32 LastID = dataReader.GetInt32(0);

            dataReader.Close();
            connection.Close();
            return LastID;

        }  
        
    }
}
