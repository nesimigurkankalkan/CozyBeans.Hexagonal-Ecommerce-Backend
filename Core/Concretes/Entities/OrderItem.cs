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
    public class OrderItem : BaseEntity
    {
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }

        // Navigation Properties
        [Required]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
