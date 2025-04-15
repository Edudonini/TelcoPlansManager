using System;
using System.ComponentModel.DataAnnotations;

namespace TelcoPlansManager.API.Entities
{
    public class Plano
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NomePlano { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Required]
        public decimal ValorMensal { get; set; }
    }
} 