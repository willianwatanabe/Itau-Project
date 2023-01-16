using Itau.Challenge.Models;

namespace Itau.Challenge.Repository.Interfaces
{
    public interface IUserRepository
    {
        UserModel GetUser(string login);
    }
}
