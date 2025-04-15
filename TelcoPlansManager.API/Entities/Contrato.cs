using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelcoPlansManager.API.Entities
{
    public class Contrato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public int PlanoId { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        [ForeignKey("PlanoId")]
        public Plano Plano { get; set; }
    }
} 