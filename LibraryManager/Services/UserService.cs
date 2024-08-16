using LibraryManager.Models;
using LibraryManager.Repositories;

namespace LibraryManager.Services
{
    public class UserService
    {
        private readonly IUserRepository<User> _userRepository;

        public UserService(IUserRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser()
        {

            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string password_hash = Console.ReadLine();

            Console.WriteLine("Enter library card number: ");
            int library_card_number = int.Parse(Console.ReadLine());

            var newUser = new User
            {
                username = username,
                password_hash = password_hash,
                library_card_number = library_card_number,
                fine_balance = 0
            };

            _userRepository.AddUser(newUser);
            Console.WriteLine("User has been added! Navigating back to menu...");
        }
    }
}