using Microsoft.EntityFrameworkCore;
using MyCareerServer.Data;
using MyCareerServer.User_Interface;
using MyCareerServer.User_Model;

namespace MyCareerServer.User_Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ResumeDBContext _context;

        public UserRepository(ResumeDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<int> GetUserId(User user)
        {
            var u = await _context.Users.Where(u => u.Email == user.Email).FirstOrDefaultAsync();
            return (int)u.Id;
        }

        public bool UserExists(User user)
        {
            return _context.Users.Any(u => u.Email == user.Email);
        }

        public bool IsRegistered(User user)
        {
            return _context.Users.Any(u => u.Email == user.Email && u.Password == user.Password);
        }

        public bool Create(User user)
        {
            _context.Users.Add(user);

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }
    }
}
