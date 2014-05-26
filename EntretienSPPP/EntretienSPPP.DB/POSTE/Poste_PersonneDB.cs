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
    public static class Poste_PersonneDB
    {
        /// <summary>
        /// Récupère une liste de Poste_Personne à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<Poste_Personne> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = "SELECT Identifiant, DateDebut, DateFin, Site, Statut, Coefficient, IdentifiantPersonne, IdentifiantPoste,Contrat, IdentiifiantSite FROM Poste_Personne";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<Poste_Personne> list = new List<Poste_Personne>();
            while (dataReader.Read())
            {

                //1 - Créer un Poste_Personne à partir des donner de la ligne du dataReader
                Poste_Personne postePersonne = new Poste_Personne();
                postePersonne.Identifiant = dataReader.GetInt32(0);
                postePersonne.DateDebut = dataReader.GetDateTime(1);
                postePersonne.DateFin = dataReader.GetDateTime(2);
                postePersonne.Statut = dataReader.GetString(3);

                postePersonne.Coefficient = dataReader.GetFloat(4);
                postePersonne.personne.Identifiant = dataReader.GetInt32(5);
                postePersonne.poste.Identifiant = dataReader.GetInt32(6);
                postePersonne.Contrat = dataReader.GetString(7);
                postePersonne.site.Identifiant = dataReader.GetInt32(7);


                //2 - Ajouter ce Poste_Personne à la list de client
                list.Add(postePersonne);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une Poste_Personne à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de Poste_Personne</param>
        /// <returns>Un Poste_Personne </returns>
        public static Poste_Personne Get(Int32 identifiant)
        {
            //Connection
            SqlConnection connection = DataBase.connection;
           
            //Commande
            String requete = @"SELECT Identifiant, DateDebut, DateFin, Site, Statut, Coefficient, IdentifiantPersonne, IdentifiantPoste,Contrat, IdentiifiantSite FROM Poste_Personne
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du Poste_Personne
            Poste_Personne postePersonne = new Poste_Personne();

            postePersonne.Identifiant = dataReader.GetInt32(0);
            dataReader.Close();
            connection.Close();
            return postePersonne;
        }
    }
}
