using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concretes.DTOs
{
    //Ürün listelemek için kullanıyoruz
    public class ProductListItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedRate { get; set; }
        public bool IsStock { get; set; }
        public decimal Rating { get; set; }
        public int ReviewCount { get; set; }
        public string Origin { get; set; }
        public string RoastLevel { get; set; }
        public string ThumbnailUrl { get; set; }
    }
    //Ürün detayları için kullanıyoruz
    public class ProductDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedRate { get; set; }
        public int StockQuantity { get; set; }
        public string Origin { get; set; }
        public string RoastLevel { get; set; }

        public string FlavorNotes { get; set; }
        public bool IsFeatured { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }

        public IEnumerable<string> ImageUrls { get; set; } = new HashSet<string>();
        public IEnumerable<ReviewDTO> Reviews { get; set; } = new HashSet<ReviewDTO>();
    }

    public class  ReviewDTO
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

}
