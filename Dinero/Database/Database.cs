using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlServerCe;
using System.Reflection;

namespace Dinero.DB
{
    public class Database
    {
        public static void CreateDatabase()
        {
            if (File.Exists(FilePath)) {
                File.Delete(FilePath);
            }

            SqlCeEngine en = new SqlCeEngine(ConnectionString);

            en.CreateDatabase();

            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("schema.sql"))
            using (StreamReader reader = new StreamReader(stream))
            {
                string sql = reader.ReadToEnd();
                SqlCeConnection connection = GetConnection();
                foreach(string snippet in sql.Split(';'))
                {
                    SqlCeCommand command = new SqlCeCommand(snippet, connection);
                    command.ExecuteNonQuery();
                }
            }

        }

        public static SqlCeConnection GetConnection()
        {
            SqlCeConnection connection = new SqlCeConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        private static string FilePath
        {
            get {return "Database.sdf";}
        }
        private static string Password
        {
            get { return "STINKY!!!!"; }
        }
        private static string ConnectionString
        {
            get { return String.Format("DataSource=\"{0}\"; Password='{1}'", FilePath, Password); }
        }
    }
}
