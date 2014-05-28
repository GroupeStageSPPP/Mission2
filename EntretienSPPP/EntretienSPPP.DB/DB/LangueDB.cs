﻿using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EntretienSPPP.DB
{
    public static class LangueDB
    {
        /// <summary>
        /// Récupère une liste de Langue à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Langue> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, Libelle FROM Langue ;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Langue> list = new List<Langue>();
            while (dataReader.Read())
            {

                //1 - Créer un Langue à partir des donner de la ligne du dataReader
                Langue langue = new Langue();
                langue.Identifiant = dataReader.GetInt32(0);
                langue.Libelle = dataReader.GetString(1);

                //2 - Ajouter ce Langue à la list de client
                list.Add(langue);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Langue à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Langue</param>
        /// <returns>Un Langue </returns>
        public static Langue Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, Libelle FROM Langue
                                WHERE Identifiant = @Identifiant ;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Langue
            Langue langue = new Langue();

            langue.Identifiant = dataReader.GetInt32(0);
            langue.Libelle = dataReader.GetString(1);
            dataReader.Close();
            connection.Close();
            return langue;
        }

        public static Boolean update(Langue langue)
        {
            Boolean isUpDAte = false ;
            //mettre a jour la base de donnée
            // retourne un boulean si l'update ses bien dérouler

            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"Update Langue set libelle = @libelle where identifiant = @identifiant  ;";
            
            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Libelle", langue.Libelle);
            commande.Parameters.AddWithValue("identifiant", langue);

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

        public static Boolean delete(Langue langue)
        {
            Boolean isDelete = false;
            //Connection
            SqlConnection connection = DataBase.connection;
           

            String requete = @"DELETE FROM langue WHERE Identifiant = @Identifiant ; ";

            SqlCommand commande = new SqlCommand(requete, connection);


            commande.Parameters.AddWithValue("Identifiant", langue);

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

        public static Langue CreateLangue(Langue langue)
        {

            SqlConnection connection = DataBase.connection;
           


            String requete = @"Insert INTO langue(libelle) Values (@libelle); SELECT SCOPE_IDENTITY()  ";

            SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("libelle", langue.Libelle);
            
           
              try
            {
                connection.Open();
                Decimal IDENTIFIANTDERNIERAJOUT = (Decimal)commande.ExecuteScalar();
                return LangueDB.Get(Int32.Parse(IDENTIFIANTDERNIERAJOUT.ToString()));
                
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
            String requete = @"SELECT Identifiant FROM Langue
                                WHERE Identifiant = (SELECT MAX(Identifiant) FROM Langue); ";
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
