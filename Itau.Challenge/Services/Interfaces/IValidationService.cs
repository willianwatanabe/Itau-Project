using Itau.Challenge.Models;

namespace Itau.Challenge.Services.Interfaces
{
    public interface IValidationService
    {
        bool isCpf(string cpf);
        bool clientValidation(ClientModel client);
    }
}
