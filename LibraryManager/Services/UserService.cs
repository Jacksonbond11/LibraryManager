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

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string password_hash = Console.ReadLine();

            Console.WriteLine("Enter library card number: ");
            int library_card_number = int.Parse(Console.ReadLine());

            var newUser = new User
            {
                username = username,
                name = name,
                password_hash = password_hash,
                library_card_number = library_card_number,
                fine_balance = 0
            };

            _userRepository.AddUser(newUser);
            Console.WriteLine("User has been added! Navigating back to menu...");
        }

        public void UpdateFineBalance()
        {
            Console.WriteLine("Enter user name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter fine amount (negative for payment): ");
            double fine = double.Parse(Console.ReadLine());
            
            User user = _userRepository.GetByName(name);
            user.fine_balance = user.fine_balance + fine;
            _userRepository.UpdateUser(user);
        }
        public IEnumerable<User> GetAllUsers()
        {
            IEnumerable<User> userList = _userRepository.GetAllUsers();

            foreach (User user in userList)
            {
                Console.WriteLine(user.name);
                Console.WriteLine("Fine: ", user.fine_balance);
            }

            return userList;
        }
    }
}