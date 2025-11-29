using Core.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstracts.IServices
{
    public interface IProductService
    {
        ProductDetailDTO GetProductById(int productId);
        IEnumerable<ProductListItemDTO> GetAllProducts();

    }
}
