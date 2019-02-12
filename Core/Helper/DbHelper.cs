using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using System.Data.SqlClient;

namespace Core.Helper
{
    public static class DbHelper
    {
        private static readonly string _dataSource = "";
        private static readonly string _userName = "";
        private static readonly string _password = "";
  

        public static void CheckDbConnection(IDbConnection con)
        {
            if (con == null)
                throw new ArgumentNullException("connection is null");
        }

        /// <summary>
        /// Liefert eine gültige IDbConnection zurück. 
        /// </summary>
        /// <returns>Dbconnection die das Interface IDbConnection aufweist.</returns>
        public static IDbConnection GetDbConnection()
        {
            var conString =
                $"DataSource={_dataSource}; UserId={_userName}; Password={_password}; DataCompression=True; CheckConnectionOnOpen=true";
            SqlConnection connection = new SqlConnection();
            var con = new SqlConnection(conString);
            return con;
        }



    }
}
