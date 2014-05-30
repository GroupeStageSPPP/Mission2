using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EntretienSPPP.DB
{
    public static class HabilitationDB
    {
        /// <summary>
        /// Récupère une liste de Habilitation à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Habilitation> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, Type FROM Habilitation ;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Habilitation> list = new List<Habilitation>();
            while (dataReader.Read())
            {

                //1 - Créer un Habilitation à partir des donner de la ligne du dataReader
                Habilitation habilitation = new Habilitation();
                habilitation.Identifiant = dataReader.GetInt32(0);
                habilitation.Type = dataReader.GetString(1);



                //2 - Ajouter ce Habilitation à la list de client
                list.Add(habilitation);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Habilitation à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Habilitation</param>
        /// <returns>Un Habilitation </returns>
        public static Habilitation Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Type FROM Habilitation
                                WHERE Identifiant = @Identifiant ;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Habilitation
            Habilitation habilitation = new Habilitation();

            habilitation.Identifiant = dataReader.GetInt32(0);
            habilitation.Type = dataReader.GetString(1);
            dataReader.Close();
            connection.Close();
            return habilitation;
        }

        public static Boolean Update(Habilitation habilitation)
        {
            Boolean isUpDAte = false ;
            //mettre a jour la base de donnée
            // retourne un boulean si l'update ses bien dérouler

            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"UPDATE habilitation SET type = @type WHERE identifiant = @identifiant  ;";
            
            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Libelle", habilitation.Type);
            commande.Parameters.AddWithValue("identifiant", habilitation);

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

        public static Boolean Delete(Habilitation habilitation)
        {
            Boolean isDelete = false;
            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"DELETE FROM habilitation WHERE Identifiant = @Identifiant ; ";

            SqlCommand commande = new SqlCommand(requete, connection);


            commande.Parameters.AddWithValue("Identifiant", habilitation);

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

        public static Habilitation Insert(Habilitation habilitation)
        {

            SqlConnection connection = DataBase.connection;
           


            String requete = @"INSERT INTO habilitation(type) VALUES (@type) SELECT SCOPE_IDENTITY() ; ";

            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("libelle", habilitation.Type);
            
           
              try
            {
                connection.Open();
                Decimal IDENTIFIANTDERNIERAJOUT = (Decimal)commande.ExecuteScalar();
                return HabilitationDB.Get(Int32.Parse(IDENTIFIANTDERNIERAJOUT.ToString()));
                
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
