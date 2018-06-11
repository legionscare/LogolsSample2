using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace ZombieWebAPI
{
    public class Repository
    {
        private string connectionString;

        public Repository()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var connectionStringConfig = builder.Build();
            connectionString = connectionStringConfig.GetConnectionString("DefaultConnection");
        }
        public IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(connectionString);
            }
        }
    }
}