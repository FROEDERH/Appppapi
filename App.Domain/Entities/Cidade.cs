using System;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities
{
    public class Cidade
    {
        [Key]
        public Guid Id { get; set; }
        public string NomeCidade { get; set; }
        public string Cep { get; set; }

        public string Uf { get; set; }
        
        public bool Ativo { get; set; }
    }
}