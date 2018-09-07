using ConsoleApplication.Model;

namespace ConsoleApplication.Interface
{
    public interface IRepository<T> where T : Entity
    {
        void Write(T entity);
    }
}
