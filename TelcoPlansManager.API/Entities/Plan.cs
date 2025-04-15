using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TelcoPlansManager.API.Entities
{
    public class Plan
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int DataLimit { get; set; }

        [Required]
        public int MinutesLimit { get; set; }

        [Required]
        public int SMSLimit { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
    }
} 