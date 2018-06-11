
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;

namespace ZombieWebAPI
{
    public class StatusRepository : Repository
    {
        public List<Status> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                
                string sql = "select p.FirstName, p.LastName, ps.StatusDescription "
                + "from person p "
                + "inner join personstatus ps "
                + "on p.PersonStatusId = ps.PersonStatusId;";

                /* sql = "CREATE DATABASE helltime"; */

                return dbConnection.Query<Status>(sql, commandType : CommandType.Text).ToList();
            }
        }
    }
}