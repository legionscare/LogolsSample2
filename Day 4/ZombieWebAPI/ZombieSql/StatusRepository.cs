using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;

namespace ZombieSqlAPI
{
    public class StatusRepository : Repository
    {
        public StatusRepository(params string[] SqlConnectorConfig)
        {
            if (SqlConnectorConfig.Length > 0)
            {
                RepositorySqlConnector = SqlConnectorConfig[0];
            }

            InitializeSqlConnector();
        }

        private void BuildSqlReport(List<Status> QueryStatuses)
        {
            SqlReport = "";
            
            foreach(Status status in QueryStatuses)
            {
                SqlReport = SqlReport 
                    + "{ " + status.FirstName 
                    + ", " + status.LastName 
                    + ", " + status.StatusDescription 
                    + " }\n";
            }
        }   

        public List<Status> QueryReportHumans()
        {
            SqlQuery = "SELECT p.FirstName, p.LastName, ps.StatusDescription "
                + "FROM person p "
                + "INNER JOIN personstatus ps "
                + "ON p.PersonStatusId = ps.PersonStatusId;";    

            List<Status> QueryStatuses = FetchSqlQuery();

            BuildSqlReport(QueryStatuses);

            return QueryStatuses;
        }

        public void QueryGetHuman(string FirstName, string LastName)
        {
            SqlQuery = "SELECT p.FirstName, p.LastName, ps.StatusDescription "
                + "FROM person p INNER JOIN personstatus ps ON p.PersonStatusId = ps.PersonStatusId " 
                + "WHERE ( FirstName = '" + FirstName + "' && LastName = '" + LastName + "' );";

            List<Status> QueryStatuses = FetchSqlQuery();

            BuildSqlReport(QueryStatuses);
        }
    
        public void QueryInsertHuman(string FirstName, string LastName, int StatusType)
        {
            SqlQuery = "INSERT INTO Person ( FirstName, LastName, PersonStatusId ) VALUES "
	            + "( '" + FirstName + "', '" + LastName + "', " + StatusType + " );";

            FetchSqlQuery();

            SqlReport = "* Inserted " + FirstName + " " + LastName + " as status type " + StatusType;
        }

        public void QueryUpdateHuman(string FirstName, string LastName, int StatusType)
        {
            SqlQuery = "UPDATE Person SET PersonStatusId = " + StatusType 
                + " WHERE ( FirstName = '" + FirstName
                + "' && LastName = '" + LastName + "' );";

            FetchSqlQuery();

            SqlReport = "* Updated " + FirstName + " " + LastName + " to status type " + StatusType;
        }

        public void QueryDeleteHuman(string FirstName, string LastName)
        {
            SqlQuery = "DELETE FROM Person " 
                + " WHERE ( FirstName = '" + FirstName
                + "' && LastName = '" + LastName + "' );";

            FetchSqlQuery();

            SqlReport = "* Deleted " + FirstName + " " + LastName;
        }
    }
}