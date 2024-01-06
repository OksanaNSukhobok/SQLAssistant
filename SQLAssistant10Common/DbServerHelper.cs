using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLAssistant10Common
{
    public class DbServerHelper
    {
        public static List<DbServerConfig> GetServerList()
        {
            var lst = new List<DbServerConfig>();
            lst.Add(new DbServerConfig()
            {
                ServerName = "MySQL - localhost - arnion",
                ServerType = DbServerType.MySql,
                ConnectionString = "Server=localhost;User Id=root;Password=root;Database=arnion;AllowZeroDate",
            });
            lst.Add(new DbServerConfig()
            {
                ServerName = "MS SQL - localDB - dbtest",
                ServerType = DbServerType.MsSql,
                ConnectionString = "Server=(localdb)\\MSSQLLocalDb;Inegrated Security =true;Database=dbtest;",
            });
            lst.Add(new DbServerConfig()
            {
                ServerName = "SQLite - dbtest",
                ServerType = DbServerType.SqLite,
                ConnectionString = @"Data Source=""C:\Work\C#\SQLAssistant\dbtest.db"";Version=3;",
            });

            return lst;
        }
    }
}
