using Itau.Challenge.Models;

namespace Itau.Challenge.Repository.Interfaces
{
    public interface IClientRepository
    {
        List<ClientModel> GetAll();

        ClientModel GetById(int id);

        void Create(ClientModel client);

        void Delete(int id);

        void Edit(ClientModel client);
    }
}
