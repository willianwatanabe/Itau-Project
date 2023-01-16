using Itau.Challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace Itau.Challenge.Data.Context
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ClientModel> Client { get; set; }

        public DbSet<UserModel> Usuarios { get; set; }
    }
}
