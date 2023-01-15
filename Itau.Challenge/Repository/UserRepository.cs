using Itau.Challenge.Data.Context;
using Itau.Challenge.Models;
using Itau.Challenge.Repository.Interfaces;

namespace Itau.Challenge.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BancoContext _context;

        public UserRepository(BancoContext context)
        {
            _context = context;
        }

        public UserModel GetUser(string login)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());

        }
    }
}
