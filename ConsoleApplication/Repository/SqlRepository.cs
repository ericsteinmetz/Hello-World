using ConsoleApplication.Interface;
using ConsoleApplication.Model;
using System;

namespace ConsoleApplication.Repository
{
    public class SqlRepository : IRepository<Entity>
    {
        public void Write(Entity entity)
        {
            //use this to create/update record in SQL
            //Entity framework or .Net data provider or Linq to SQL

            throw new NotImplementedException();
        }
    }
}
