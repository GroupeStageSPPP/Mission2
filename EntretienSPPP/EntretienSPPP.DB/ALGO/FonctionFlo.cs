using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntretienSPPP.DB.ALGO
{
    public static class FonctionFlo
    {
        public static void EliminerDoublonsListe(List<string> liste)
        {
            for (int i = 0; i < liste.Count() - 1; i++)
            {
                for (int j = i + 1; j < liste.Count(); j++)
                {
                    if (liste[i] == liste[j])
                    {
                        liste.RemoveAt(j);
                        if (j == liste.Count())
                        {
                            break;
                        }
                    }
                }
            }
        }
        public static List<string> GetListChamp(string champ, string table)
        {
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPP"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());

            String requete = "SELECT " + champ + " FROM " + table;
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);

            SqlDataReader dataReader = commande.ExecuteReader();

            List<string> list = new List<string>();
            while (dataReader.Read())
            {
                list.Add(dataReader.GetString(0));
            }
            dataReader.Close();
            connection.Close();

            EliminerDoublonsListe(list);
            return list;
        }
    }
}
