using LibraryManager.Models;
using LibraryManager.Data;

namespace LibraryManager.Repositories
{
    public class UserRepository : IUserRepository<User>
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public User GetById(int id)
        {
            return _context.users.Find(id);
        }

        public User GetByName(string name)
        {
            return _context.users.Find(name);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.users.ToList();
        }

        public void AddUser(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.users.Update(user);
            _context.SaveChanges();
        }
        public void DeleteUser(User user)
        {
            _context.users.Remove(user);
            _context.SaveChanges();
        }

    }
}