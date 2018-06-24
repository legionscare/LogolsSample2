using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ZombieSqlAPI;
using MainProgram = ZombieMain.Program;

namespace ZombieWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ZombieWebAPIController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "1", "2" };
        }

        // GET api/ZombieWebAPI/report
        [HttpGet("{QueryType}")]
        public string Get(string QueryType)
        {
            switch (QueryType)
            {
                case "create":

                    MainProgram.QueryRepository.CreateDatabase();

                    return "* Creating database";
                        
                case "execute":

                    MainProgram.QueryRepository.ExecuteSchemaFile("\\SqlSchemas\\Day 3 - SQL Zombies.sql");

                    return "Query:\n\n"
                        + MainProgram.QueryRepository.SqlQuery
                        + "\n\nReport: \n\n"
                        + MainProgram.QueryRepository.SqlReport;

                case "report":
                
                    MainProgram.QueryRepository.QueryReportHumans();

                    return "Query:\n\n"
                        + MainProgram.QueryRepository.SqlQuery
                        + "\n\nReport: \n\n"
                        + MainProgram.QueryRepository.SqlReport;

                case "kill-exit":

                    Console.WriteLine ("Abandoned all ye hope");
                    Environment.Exit(1);
                    break;

                default:
                    break;                
            }

            return "nothing to see here";
        }

        // GET api/ZombieWebAPI/report/idk
        [HttpGet("{QueryType}/{NotImplemented}")]
        public string Get(string QueryType, string NotImplemented)
        {
            switch (QueryType)
            {
                default:
                    break;                
            }

            return "nothing to see here";
        }

        // GET api/ZombieWebAPI/delete/Michael/Jackson
        [HttpGet("{QueryType}/{FirstName}/{LastName}")]
        public string Get(string QueryType, string FirstName, string LastName)
        {
            switch (QueryType)
            {
                case "get":

                    MainProgram.QueryRepository.QueryGetHuman(FirstName, LastName);
 
                    return "Query:\n\n"
                        + MainProgram.QueryRepository.SqlQuery
                        + "\n\nReport: \n\n"
                        + MainProgram.QueryRepository.SqlReport;
                
                case "delete":

                    MainProgram.QueryRepository.QueryDeleteHuman(FirstName, LastName);
 
                    return "Query:\n\n"
                        + MainProgram.QueryRepository.SqlQuery
                        + "\n\nReport: \n\n"
                        + MainProgram.QueryRepository.SqlReport;

                default:
                
                    break;                
            }

            return "nothing to see here";
        }

        // GET api/ZombieWebAPI/insert/Michael/Jackson/3
        [HttpGet("{QueryType}/{FirstName}/{LastName}/{StatusType}")]
        public string Get(string QueryType, string FirstName, string LastName, int StatusType)
        {
            if ((StatusType >= 0) && (StatusType <= 5))
            {        
                switch (QueryType)
                {
                    case "insert":

                        MainProgram.QueryRepository.QueryInsertHuman(FirstName, LastName, StatusType);

                        return "Query:\n\n"
                            + MainProgram.QueryRepository.SqlQuery
                            + "\n\nReport: \n\n"
                            + MainProgram.QueryRepository.SqlReport;

                    case "update":

                        MainProgram.QueryRepository.QueryUpdateHuman(FirstName, LastName, StatusType);

                        return "Query:\n\n"
                            + MainProgram.QueryRepository.SqlQuery
                            + "\n\nReport: \n\n"
                            + MainProgram.QueryRepository.SqlReport;

                    default:

                        break;                
                }
                
                return "nothing to see here";
            }
            else
            {
                return "invalid status type encountered";
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Michael/Jackson
        [HttpDelete("{FirstName}/{LastName}")]
        public void Delete(String FirstName, string LastName)
        {
            MainProgram.QueryRepository.QueryDeleteHuman(FirstName, LastName);

        /* 
            return "Query:\n\n"
                + MainProgram.QueryRepository.SqlQuery
                + "\n\nReport: \n\n"
                + MainProgram.QueryRepository.SqlReport;
        */
        }
    }
}
