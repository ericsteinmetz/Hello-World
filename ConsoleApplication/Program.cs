using API.Controllers;
using System;
using System.Configuration;
using System.Web.Http.Results;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new DefaultController();

            var response = controller.Get();
            var contentResult = response as OkNegotiatedContentResult<string>;

            var entity = new Model.Entity(contentResult.Content);

            var repoToUse = ConfigurationManager.AppSettings["RepoToUse"].ToString();

            switch(repoToUse)
            {
                case "SQL":
                    var sqlRepo = new Repository.SqlRepository();
                    /* This will throw errors but just show it can work
                    sqlRepo.Write(entity);
                    */
                    break;

                case "Log":
                    var logRepo = new Repository.LogRepository();
                    /* This will throw errors but just show it can work
                    logRepo.Write(entity);
                    */
                    break;
            }

            Console.WriteLine(entity.Message);
            Console.ReadKey();
        }
    }
}
