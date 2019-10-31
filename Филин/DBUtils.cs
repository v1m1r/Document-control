using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Филин
{
    class DBUtils
    {
        public static SQLiteConnection GetDBConnection()
        {
            string datasource = @"controlbd.sqlite";

            return DBSQLServerUtils.GetDBConnection(datasource);
        }
    }
}
