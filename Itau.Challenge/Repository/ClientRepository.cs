using Itau.Challenge.Data.Context;
using Itau.Challenge.Models;
using Itau.Challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Itau.Challenge.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly BancoContext _context;

        public ClientRepository(BancoContext context)
        {
            _context = context;
        }

        public List<ClientModel> GetAll()
        {
            return _context.Client.ToList();
        }

        public ClientModel GetById(int id)
        {
            try
            {
                return _context.Client.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possivel localizar o cliente", e);
                return new ClientModel();
            }
        }

        public void Create(ClientModel client)
        {
            client.CreationDate = DateTime.Now;

            _context.Add(client);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            try
            {
                var client = GetById(id);
                _context.Remove(client);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possível deletar o registro.", e);
            }
        }

        public void Edit(ClientModel client)
        {
            try
            {
                _context.Update(client);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possível atualizar.", e);
            }
        }
    }
}
