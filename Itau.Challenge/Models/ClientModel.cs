using Itau.Challenge.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Itau.Challenge.Models
{
    public class ClientModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Cpf { get; set; }

        public EGender? Gender { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string? Profession { get; set; }

        public DateTime Birth { get; set; }

        public DateTime CreationDate { get; set; }
    }
}