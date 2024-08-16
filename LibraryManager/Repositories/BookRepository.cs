using LibraryManager.Data;
using LibraryManager.Models;

namespace LibraryManager.Repositories
{
    public class BookRepository : IBookRepository<Book>
    {
        private readonly BookContext _context;

        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public Book GetById(int id)
        {
            return _context.Books.Find(id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}