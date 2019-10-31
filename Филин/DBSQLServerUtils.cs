using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace Филин
{
    class DBSQLServerUtils
    {
        public static SQLiteConnection GetDBConnection(string datasource)
        {
            string connString = @"Data Source=" + datasource + ";Version=3;";
            SQLiteConnection conn = new SQLiteConnection(connString);
            return conn;

        }
    }
}
