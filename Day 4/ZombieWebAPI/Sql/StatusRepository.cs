using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;

namespace ZombieWebAPI
{
    public class StatusRepository : Repository
    {
        public string SqlQuery { get; set; }
        public string SqlReport { get; set; }

        private List<Status> FetchSqlQuery()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                
                return dbConnection.Query<Status>(SqlQuery, commandType : CommandType.Text).ToList();
            }
        }

        private string BuildQueryReport(List<Status> statuses)
        {
            SqlReport = "";
            
            foreach(Status status in statuses)
            {
                SqlReport = SqlReport 
                    + "{ " + status.FirstName 
                    + ", " + status.LastName 
                    + ", " + status.StatusDescription 
                    + " }\n";
            }

            return SqlReport;
        }
    
        public List<Status> QueryReport()
        {
            SqlQuery = "select p.FirstName, p.LastName, ps.StatusDescription "
                + "from person p "
                + "inner join personstatus ps "
                + "on p.PersonStatusId = ps.PersonStatusId;";    

            List<Status> statuses = FetchSqlQuery();
            BuildQueryReport(statuses);

            return statuses;
        }
    }
}