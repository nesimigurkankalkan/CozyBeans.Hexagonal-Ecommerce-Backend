using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concretes.Entities
{
    public class Review :BaseEntity
    {

        [Range(1, 5)]
        public int Rating { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Comment { get; set; }

        public bool IsVerifiedPurchase { get; set; } = false;

        public bool IsApproved { get; set; } = false;

        // Navigation Properties
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
