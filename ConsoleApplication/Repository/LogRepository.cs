using ConsoleApplication.Interface;
using ConsoleApplication.Model;

namespace ConsoleApplication.Repository
{
    public class LogRepository : IRepository<Entity>
    {
        public void Write(Entity entity)
        {
            //use this to write to a log file
            //system.io namespace

            throw new System.NotImplementedException();
        }
    }
}
