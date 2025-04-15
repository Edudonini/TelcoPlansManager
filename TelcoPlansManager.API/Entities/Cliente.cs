using System;
using System.ComponentModel.DataAnnotations;

namespace TelcoPlansManager.API.Entities
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public string Documento { get; set; }

        public DateTime DataCadastro { get; set; }
    }
} 