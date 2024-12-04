using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionMold_TrackingSystem.UtilityClass
{
    public class DbConnection
    {
        private readonly string _connection;
        public DbConnection()
        {
            _connection = "Data Source=192.168.101.41;Initial Catalog=MoldTrackingSystem;User ID=Administrator;Encrypt=False";
        }
        public SqlConnection GetConnection()
        {
            var conn = new SqlConnection(_connection);
            return conn;
        }
    }
}
