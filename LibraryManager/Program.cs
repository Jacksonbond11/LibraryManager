using LibraryManager.Authentication;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using LibraryManager;
using LibraryManager.Services;
using LibraryManager.Repositories;
using LibraryManager.Models;
using LibraryManager.Data;
using Microsoft.Extensions.DependencyInjection;



internal class Program
{
    private static void Main(string[] args)
    {

        // Database db = new Database();
        // db.CreateTable("CREATE TABLE users (id INTEGER PRIMARY KEY AUTOINCREMENT,username TEXT NOT NULL UNIQUE,password_hash TEXT NOT NULL,name TEXT NOT NULL,library_card_number TEXT UNIQUE,fine_balance REAL DEFAULT 0.00); ");
        var ServiceCollection = new ServiceCollection();
        ConfigureServices(ServiceCollection);

        var serviceProvider = ServiceCollection.BuildServiceProvider();

        bool x = true;
        while (x)
        {

            Console.WriteLine("Selection an option: ");
            Console.WriteLine("1. Manage Books");
            Console.WriteLine("2. Manage Users");
            Console.WriteLine("3. Browse Books");
            Console.WriteLine("4. Logout");

            string selection = Console.ReadLine();


            if (selection == "1")
            {
                var bookService = serviceProvider.GetRequiredService<BookService>();

                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Delete Book");

                string selection2 = Console.ReadLine();

                if (selection2 == "1")
                {
                    bookService.AddBook();
                }
                else if (selection2 == "2")
                {
                    bookService.DeleteBook();
                }
            }
            else if (selection == "2")
            {
                var userService = serviceProvider.GetRequiredService<UserService>();

                Console.WriteLine("1. Add New User");
                Console.WriteLine("2. Delete User");
                Console.WriteLine("3. View All Users");
                Console.WriteLine("4. Manage User Fines");

                string selection2 = Console.ReadLine();

                if (selection2 == "1")
                {
                    userService.AddUser();
                }

                else if (selection2 == "3")
                {
                    userService.GetAllUsers();
                }

                else if(selection2 == "4")
                {
                    
                    userService.UpdateFineBalance();
                }

            }
            else if (selection == "4")
            {
                x = false;
                Console.WriteLine("Signing out...");
            }

        }




    }

    private static void ConfigureServices(IServiceCollection services)
    {
services.AddDbContext<BookContext>(options => options.UseSqlite("Data Source=database.sqlite"));
services.AddDbContext<UserContext>(options => options.UseSqlite("Data Source=database.sqlite"));
services.AddScoped<IBookRepository<Book>, BookRepository>();
services.AddScoped<BookService>();
services.AddScoped<IUserRepository<User>, UserRepository>();
services.AddScoped<UserService>();



    }
}