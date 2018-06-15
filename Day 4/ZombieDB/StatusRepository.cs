
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;

namespace ZombieDB
{
    public class StatusRepository : Repository
    {
        public string[] SqlQuery { get; set; }
        public List<Status> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                
                SqlQuery = "select p.FirstName, p.LastName, ps.StatusDescription "
                + "from person p "
                + "inner join personstatus ps "
                + "on p.PersonStatusId = ps.PersonStatusId;";

                /* sql = "CREATE DATABASE helltime"; */

                return dbConnection.Query<Status>(SqlQuery, commandType : CommandType.Text).ToList();
            }
        }

        
                    StatusRepository repository = new StatusRepository();
        
        public string BuildReport(List<Status> statuses)
        {
            string Report = "";
            
            foreach(Status status in statuses)
            {
                Report = Report + status.FirstName + " " + status.LastName + " is " + status.StatusDescription + ".\n";
            }

            return Report;
        }
    }
}