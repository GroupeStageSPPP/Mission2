using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EntretienSPPP.DB
{
    public static class HabiliteDB
    {
       
        public static List<Habilite> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant ,Type FROM Habilite";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Habilite> list = new List<Habilite>();
            while (dataReader.Read())
            {

                //1 - Créer un Habilite à partir des donner de la ligne du dataReader
                Habilite habilite = new Habilite();
                habilite.Identifiant = dataReader.GetInt32(0);
                habilite.Type = dataReader.GetString(1);



                //2 - Ajouter ce Habilite à la list de client
                list.Add(habilite);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Habilite à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Habilite</param>
        /// <returns>Un Habilite </returns>
        public static Habilite Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Type FROM Habilite
                                WHERE Identifiant = @Identifiant ";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Habilite
            Habilite habilite = new Habilite();

            habilite.Identifiant = dataReader.GetInt32(0);
            habilite.Type = dataReader.GetString(1);
            dataReader.Close();
            connection.Close();
            return habilite;
        }

        public static Boolean Update(Habilite habilite)
        {
            Boolean isUpDAte = false ;
            //mettre a jour la base de donnée
            // retourne un boulean si l'update ses bien dérouler

            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"UPDATE habilite SET type = @type WHERE identifiant = @identifiant  ";
            
            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Libelle", habilite.Type);
            commande.Parameters.AddWithValue("identifiant", habilite);

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

        public static Boolean Delete(Habilite habilite)
        {
            Boolean isDelete = false;
            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"DELETE FROM habilite WHERE Identifiant = @Identifiant  ";

            SqlCommand commande = new SqlCommand(requete, connection);


            commande.Parameters.AddWithValue("Identifiant", habilite);

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

        public static Habilite Insert(Habilite habilite)
        {

            SqlConnection connection = DataBase.connection;
           


            String requete = @"INSERT INTO habilite(type) VALUES (@type) SELECT SCOPE_IDENTITY()";

            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("libelle", habilite.Type);
            
           
              try
            {
                connection.Open();
                Decimal IDENTIFIANTDERNIERAJOUT = (Decimal)commande.ExecuteScalar();
                return HabiliteDB.Get(Int32.Parse(IDENTIFIANTDERNIERAJOUT.ToString()));
                
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
