using MyCareerServer.User_Model;

namespace MyCareerServer.User_Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<int> GetUserId(User user);
        bool UserExists(User user);
        bool IsRegistered(User user);
        bool Create(User user);
        bool Save();
    }
}
