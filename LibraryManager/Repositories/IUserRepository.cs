using LibraryManager.Models;

namespace LibraryManager.Repositories
{
    public interface IUserRepository<T>
    {
        T GetById(int id);
        User GetByName(string name);
        IEnumerable<T> GetAllUsers();
        void AddUser(T entity);
        void UpdateUser(T entity);
        void DeleteUser(T entity);

    }
}