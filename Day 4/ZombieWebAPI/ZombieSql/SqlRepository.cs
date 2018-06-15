using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

using Dapper;
using System.Linq;

namespace ZombieSqlAPI
{
    public class Repository
    {
        private string connectionString;

        public string RepositorySqlConnector = "DefaultConnection";

        internal void InitializeSqlConnector()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            
            var connectionStringConfig = builder.Build();

            connectionString = connectionStringConfig.GetConnectionString(RepositorySqlConnector);
        }

        private IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(connectionString);
            }
        }

        public string SqlQuery { get; set; }
        public string SqlReport { get; set; }

        internal List<Status> FetchSqlQuery()
        {
            List<Status> QueryStatuses = new List<Status>();

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                
                return dbConnection.Query<Status>(SqlQuery, commandType : CommandType.Text).ToList();
            }
        }
    }
}