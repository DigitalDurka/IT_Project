using Domain.Models;

namespace Domain.IRepositories
{
    public interface IUserRepository : IRepository<User>
    {

        bool IsExist(string login, string password);
        bool IsExist(string login);
        bool IsValid(User user);
        User GetByLogin(string login);
    }
}