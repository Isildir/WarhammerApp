using WarhammerApp.API.Entities.Models;

namespace WarhammerApp.API.Interfaces
{
    public interface IUserService
    {
        User Authenticate(string login, string password);

        User Create(User user, string password);

        void Delete(int id);

        User GetById(int id);
    }
}