using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using EntretienSPPP.library;


namespace EntretienSPPP.DB
{
    class EvaluationMoiDB
    {
        /// <summary>
        /// Récupère une liste de EvaluationMoi à partir de la base de données
        /// </summary>
        /// <returns>Une liste de client</returns>
        public static List<EvaluationMoi> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = "SELECT IdentifiantEntretien, Communication, SensRelationnel, Implication, Competence,Performance,Management,Objectifs,Commentaire FROM EvaluationMoi ;";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<EvaluationMoi> list = new List<EvaluationMoi>();
            while (dataReader.Read())
            {

                //1 - Créer un EvaluationMoi à partir des donner de la ligne du dataReader
                EvaluationMoi evaluationMoi        = new EvaluationMoi();
                evaluationMoi.IdentifiantEntretien = dataReader.GetInt32(0); 
                evaluationMoi.Communication        = dataReader.GetInt16(1); 
                evaluationMoi.SensRelationnel      = dataReader.GetInt16(2);
                evaluationMoi.Implication          = dataReader.GetInt16(3);
                evaluationMoi.Competence           = dataReader.GetInt16(4);
                evaluationMoi.Performance          = dataReader.GetInt16(5);
                evaluationMoi.Management           = dataReader.GetInt16(6);
                evaluationMoi.Objectifs            = dataReader.GetInt16(7);
                evaluationMoi.Commentaire          = dataReader.GetString(8);
               

                //2 - Ajouter ce EvaluationMoi à la list de client
                list.Add(evaluationMoi);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère une EvaluationMoi à partir d'un identifiant de client
        /// </summary>
        /// <param name="Identifiant">Identifant de EvaluationMoi</param>
        /// <returns>Un EvaluationMoi </returns>
        public static EvaluationMoi Get(Int32 identifiantEntretien)
        {
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = @"SELECT IdentifiantEntretien, Communication, SensRelationnel, Implication, Competence,Performance,Management,Objectifs,Commentaire FROM EvaluationMoi
                                WHERE IdentifiantEntretien = @IdentifiantEntretien ;";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("IdentifiantEntretien", identifiantEntretien);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création du EvaluationMoi
            EvaluationMoi evaluationMoi = new EvaluationMoi();
            evaluationMoi.IdentifiantEntretien = dataReader.GetInt32(0);
            evaluationMoi.Communication = dataReader.GetInt16(1);
            evaluationMoi.SensRelationnel = dataReader.GetInt16(2);
            evaluationMoi.Implication = dataReader.GetInt16(3);
            evaluationMoi.Competence = dataReader.GetInt16(4);
            evaluationMoi.Performance = dataReader.GetInt16(5);
            evaluationMoi.Management = dataReader.GetInt16(6);
            evaluationMoi.Objectifs = dataReader.GetInt16(7);
            evaluationMoi.Commentaire = dataReader.GetString(8);
            
            dataReader.Close();
            connection.Close();
            return evaluationMoi;
        }

        public static Boolean update(EvaluationMoi evaluationMoi) // la modification fonctionne pour tout sauf civilite et groupe
        {
            Boolean isUpDAte = false;
            //mettre a jour la base de donnée
            // retourne un boulean si l'update ses bien dérouler

            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());

            String requete = @"Update EvaluationMoi set Communication = @Communication,SensRelationnel = @SensRelationnel, Implication = @Implication, Competence = @Competence, Performance = @Performance, Management =   @Management , Objectifs = @Objectifs,Commentaire =@Commentaire  where identifiantEntretien = @identifiantEntretien ;";

            SqlCommand commande = new SqlCommand(requete, connection);



            commande.Parameters.AddWithValue("Communication", evaluationMoi.Communication);
            commande.Parameters.AddWithValue("SensRelationnel", evaluationMoi.SensRelationnel);
            commande.Parameters.AddWithValue("Implication", evaluationMoi.Implication);
            commande.Parameters.AddWithValue("Competence", evaluationMoi.Competence);
            commande.Parameters.AddWithValue("Performance", evaluationMoi.Performance);
            commande.Parameters.AddWithValue("Management", evaluationMoi.Management);
            commande.Parameters.AddWithValue("Objectifs", evaluationMoi.Objectifs);
            commande.Parameters.AddWithValue("Commentaire", evaluationMoi.Commentaire);
            commande.Parameters.AddWithValue("identifiantEntretien", evaluationMoi.IdentifiantEntretien);
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

        public static Boolean delete(EvaluationMoi evaluationMoi)
        {
            Boolean isDelete = false;
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());

            String requete = @"DELETE FROM EvaluationMoi WHERE IdentifiantEntretien = @IdentifiantEntretien ;";

            SqlCommand commande = new SqlCommand(requete, connection);


            commande.Parameters.AddWithValue("IdentifiantEntretien", evaluationMoi.IdentifiantEntretien);

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

        public static EvaluationMoi CreerEvaluationMoi(EvaluationMoi evaluationMoi)
        {

            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPPConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());


            String requete = @"Insert INTO EvalutationMoi Communication,SensRelationnel,Implication,Competence,Performance,Management,Objectifs,Commentaire,IdentifiantEntretien) Values (@Communication,@SensRelationnel,@Implication,@Competence,@Performance,@Management,@Objectifs,@Commentaire,@identifiantEntretien);";

              SqlCommand commande = new SqlCommand(requete, connection);

            commande.Parameters.AddWithValue("Communication",evaluationMoi.Communication);
            commande.Parameters.AddWithValue("SensRelationnel",evaluationMoi.SensRelationnel);
            commande.Parameters.AddWithValue("Implication",evaluationMoi.Implication);
            commande.Parameters.AddWithValue("Competence",evaluationMoi.Competence);
            commande.Parameters.AddWithValue("Performance",evaluationMoi.Performance);
            commande.Parameters.AddWithValue("Management", evaluationMoi.Management);
            commande.Parameters.AddWithValue("Objectifs", evaluationMoi.Objectifs);
            commande.Parameters.AddWithValue("Commentaire", evaluationMoi.Commentaire);
            commande.Parameters.AddWithValue("IdentifiantEntretien", evaluationMoi.IdentifiantEntretien);  try
              {
                   connection.Open();
                Decimal IDENTIFIANTDERNIERAJOUT = (Decimal)commande.ExecuteScalar();
                  return EvaluationMoiDB.Get(Int32.Parse(IDENTIFIANTDERNIERAJOUT.ToString()));
                
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
    

