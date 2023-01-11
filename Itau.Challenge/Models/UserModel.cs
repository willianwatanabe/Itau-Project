using System;

namespace Itau.Challenge.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Profile { get; set; }

        public bool IsValid(UserModel login)
        {
            return !string.IsNullOrEmpty(login.UserName) || !string.IsNullOrEmpty(login.Password);
        }
    }
}