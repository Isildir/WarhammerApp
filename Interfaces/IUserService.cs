using WarhammerProfessionApp.Entities.Models;

namespace WarhammerProfessionApp.Interfaces
{
    public interface IUserService
    {
        User Authenticate(string login, string password);

        User Create(User user, string password);

        void Delete(int id);

        User GetById(int id);
    }
}