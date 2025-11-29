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
    public class ProductImage :BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string ImageUrl { get; set; }
        public bool IsPrimary { get; set; } = false;
        public int DisplayOrder { get; set; }
        // Navigation Properties
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
