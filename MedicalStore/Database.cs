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
        //public static SqlCommand command;
        public static SqlDataReader dataReader;
        public static string connectionString;

        public static void SqlCon()
        {
            //connectionString = "Data Source = tcp:rdsdeployment.database.windows.net,1433;Initial Catalog = sampletode;User ID = testuser;Password = password@123";
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MedicalStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            _con = new SqlConnection(connectionString);
            try
            {
                _con.Open();
                //Console.WriteLine("Database Connected..!");
                _con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e);
            }
        }
        //To Fetch Details
        //public void FetchData()
        //{
        //    _con.Open();
        //    string Sql1 = "SELECT * FROM medicines";
        //    command = new SqlCommand(Sql1, _con);
        //    dataReader = command.ExecuteReader();
        //    while (dataReader.Read())
        //    {
        //        Console.WriteLine("Emp ID\t\tEmp Name\t\tEmp Team");
        //        Console.WriteLine("------\t\t--------\t\t--------");
        //        Console.WriteLine("{0}\t\t{1}\t\t{2}", dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3));
        //    }
        //    _con.Close();
        //}
    }
}
