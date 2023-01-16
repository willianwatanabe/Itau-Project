using Itau.Challenge.Models;

namespace Itau.Challenge.Services.Interfaces
{
    public interface IValidationService
    {
        Tuple<bool, string> IsCpf(string cpf);
    }
}
