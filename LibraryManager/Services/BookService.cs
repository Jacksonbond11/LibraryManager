using LibraryManager.Models;
using LibraryManager.Repositories;

namespace LibraryManager.Services
{
    public class BookService
    {
        private readonly IBookRepository<Book> _bookRepository;

        public BookService(IBookRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook()
        {
            Console.WriteLine("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Book ISBN: ");
            string iSBN = Console.ReadLine();

            Console.WriteLine("Enter Book Publisher: ");
            string publisher = Console.ReadLine();

            Console.WriteLine("Enter Book PublicationYear: ");
            int publicationYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Book Category: ");
            string category = Console.ReadLine();

            Console.WriteLine("Enter Copies Available: ");
            int copiesAvailable = int.Parse(Console.ReadLine());


            var newBook = new Book
            {
                Title = title,
                ISBN = iSBN,
                Publisher = publisher,
                PublicationYear = publicationYear,
                Category = category,
                CopiesAvailable = copiesAvailable
            };

            _bookRepository.AddBook(newBook);
            Console.WriteLine("Book has been added! Navigating back to menu...");
        }

        public void DeleteBook()
        {
            Console.WriteLine("Enter Book Title: ");
            string title = Console.ReadLine();

            var newBook = new Book
            {
                Title = title,

            };

            _bookRepository.DeleteBook(newBook);
            Console.WriteLine("Book has been deleted! Navigating back to menu...");
        }



    }
}