using Itau.Challenge.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Itau.Challenge.Models
{
    public class ClientModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF", AllowEmptyStrings = false)]
        public string Cpf { get; set; }

        public EGender? Gender { get; set; }

        [Required(ErrorMessage = "Preencha o campo endereço", AllowEmptyStrings = false)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Preencha o campo celular", AllowEmptyStrings = false)]
        public string PhoneNumber { get; set; }

        public string? Profession { get; set; }

        [Required(ErrorMessage = "Preencha o campo nascimento", AllowEmptyStrings = false)]
        public DateTime Birth { get; set; }

        public DateTime CreationDate { get; set; }
    }
}