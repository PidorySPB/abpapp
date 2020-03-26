using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ABPa
{
    class DBConn
    {
        private DBConn()
        {
        }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }
        private string host = string.Empty;
        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            set { connection = value; }
            get { return connection; }
        }

        private static DBConn _instance = null;
        public static DBConn Instance()
        {
            if (_instance == null)
                _instance = new DBConn();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName) || String.IsNullOrEmpty(host))
                    return false;
                string connstring = string.Format("Server={1};Port=3306;Database={0};Uid={0};Pwd=Q12we34rt5", databaseName,host);
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }

        public void Close()
        {
            connection.Close();
        }
    }

}
