using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TelcoPlansManager.API.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        [Phone]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public int? PlanId { get; set; }
        public Plan Plan { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
    }
} 