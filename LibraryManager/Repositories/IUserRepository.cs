namespace LibraryManager.Repositories
{
    public interface IUserRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAllUsers();
        void AddUser(T entity);
        void UpdateUser(T entity);
        void DeleteUser(T entity);
    }
}