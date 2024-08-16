namespace LibraryManager.Repositories
{
    public interface IBookRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAllBooks();
        void AddBook(T entity);
        void UpdateBook(T entity);
        void DeleteBook(T entity);

    }
}