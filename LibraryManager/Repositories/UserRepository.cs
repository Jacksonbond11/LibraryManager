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
            return _context.user.Find(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.user.ToList();
        }

        public void AddUser(User user)
        {
            _context.user.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.user.Update(user);
            _context.SaveChanges();
        }
        public void DeleteUser(User user)
        {
            _context.user.Remove(user);
            _context.SaveChanges();
        }
    }
}