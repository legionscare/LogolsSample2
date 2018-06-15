using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
            Console.WriteLine ("Sent some stuff");
            return new string[] { "1", "2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            switch (id)
            {
                case "report":
                
                    MainProgram.QueryRepository.QueryReport();

                    Console.WriteLine ("Sent query report to web");

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

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
