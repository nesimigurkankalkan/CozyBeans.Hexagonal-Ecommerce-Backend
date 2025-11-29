using Core.Abstracts.IRepositories;
using Core.Concretes.Entities;
using Data.Context;
using Utils.Generics;

namespace Data.Reposaitories
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(ShopContexts db) : base(db) 
        {
        }
    }
}
