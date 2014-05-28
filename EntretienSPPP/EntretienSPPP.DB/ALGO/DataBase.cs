using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntretienSPPP.DB
{
    public static class DataBase
    {
        public static SqlConnection connection = new SqlConnection("Data Source=PC-JEOFF;Initial Catalog=EntretienSPPP;Integrated Security=True");

    }
}
