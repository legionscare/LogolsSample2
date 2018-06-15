using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;

namespace ZombieDB
{
    class Program
    {
        static void Main(string[] args)
        {
            StatusRepository repository = new StatusRepository();

            List<Status> statuses = repository.GetAll();

            foreach(Status status in statuses)
            {
                Console.WriteLine(status.FirstName + " " + status.LastName + " is " + status.StatusDescription);
            }
        }
    }
}
