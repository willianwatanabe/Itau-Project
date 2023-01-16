using Itau.Challenge.Enums;

namespace Itau.Challenge.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public EProfile Perfil { get; set; }

        public bool isValid (string password)
        {
            return Password == password;
        }
    }
}