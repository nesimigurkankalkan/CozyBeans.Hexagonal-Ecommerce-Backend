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
    public class Product :BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string SKU { get; set; } // Stok Kodu
        [MaxLength(1000)]
        public string Description { get; set; }
        public decimal Price { get; set; } // İndirimli olarak gider
        public decimal? DiscountRate { get; set; } = 0;
        public int StockQuantity { get; set; }


        [MaxLength(100)]
        public string Origin { get; set; } // Kökeni: Kolombiya, Etiyopya vb.

        [MaxLength(100)]
        public string RoastLevel { get; set; } // Kavurma Seviyesi: Açık, Orta, Koyu

        [MaxLength(200)]
        public string FlavorNotes { get; set; } // Tat notları
        [Column(TypeName = "decimal(3,1)")]
        public decimal? Rating { get; set; }
        public bool IsFeatured { get; set; }


        public DateTime? DiscountStartDate { get; set; }
        public DateTime? DiscountEndDate { get; set; }

        [Required, ForeignKey("Subcategory")]
        public int SubcategoryId { get; set; }
        
        public virtual ICollection<Subcategory> Subcategory { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
    }
}
