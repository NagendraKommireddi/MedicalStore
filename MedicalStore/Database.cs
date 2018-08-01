using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MedicalStore
{
    class Database 
    {
        public static SqlConnection _con = null;
        public static SqlDataAdapter dataadapter;
        public static DataSet ds = new DataSet();
        //Database Connection Method
        public static void SqlCon()
        {  
            try
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MedicalStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                _con = new SqlConnection(connectionString);
                FillDataset();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e);
            }
        }

        public static void FillDataset()
        {
            
            string Sql1 = "SELECT * FROM medicines";
            dataadapter = new SqlDataAdapter(Sql1, _con);
            _con.Open();
            dataadapter.Fill(ds, "Medicines");
            _con.Close();
        }
    }
}
