using Core.Abstracts.IRepositories;
using Core.Concretes.Entities;
using Data.Context;
using Utils.Generics;

namespace Data.Reposaitories
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(ShopContexts db) : base(db)
        {
        }
    }
}
