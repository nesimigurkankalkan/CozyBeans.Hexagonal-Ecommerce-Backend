using Core.Abstracts.IRepositories;
using Core.Concretes.Entities;
using Data.Context;
using Utils.Generics;

namespace Data.Reposaitories
{
    public class ProductImageRepository : GenericRepository<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(ShopContexts db) : base(db)
        {
        }
    }
}
