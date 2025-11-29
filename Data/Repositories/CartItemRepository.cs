using Core.Abstracts.IRepositories;
using Core.Concretes.Entities;
using Data.Context;
using Utils.Generics;

namespace Data.Reposaitories
{
    public class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(ShopContexts db) : base(db) 
        {
        }
    }
}
