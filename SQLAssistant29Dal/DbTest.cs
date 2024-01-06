using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanDal
{
    public class DbTest
    {
        public static string DoDbTest()
        {
            string s = " ";

            using (var cnn = DbServerFactoryMySql.GetDbConnection())
            {
                var cmd = cnn.CreateCommand();
                cmd.CommandText = "SELECT 1";
                cnn.Open();

                var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    // get the results of each column
                    s += (string)rdr[0].ToString() + " ";
                }
            }
            return s;
        }
    }
}
