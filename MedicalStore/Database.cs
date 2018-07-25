using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MedicalStore
{
    class Database
    {
        public static SqlConnection _con = null;
        public static SqlDataAdapter dataadapter;
        public static string connectionString;
        //Database Connection Method
        public static void SqlCon()
        {  
            try
            {
                connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MedicalStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                _con = new SqlConnection(connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e);
            }
        }
    }
}
