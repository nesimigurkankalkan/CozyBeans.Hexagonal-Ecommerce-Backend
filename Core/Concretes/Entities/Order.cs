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
    public class Order :BaseEntity
    {
        [Required]
        public decimal SubTotal { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } // Pending, Processing, Shipped, Delivered, Cancelled
        [MaxLength(50)]
        public string PaymentMethod { get; set; } // CreditCard, BankTransfer, CashOnDelivery

        [MaxLength(50)]
        public string PaymentStatus { get; set; } // Pending, Paid, Failed, Refunded


        [MaxLength(500)]
        public string ShippingAddress { get; set; }

        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; } 
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    }
}
