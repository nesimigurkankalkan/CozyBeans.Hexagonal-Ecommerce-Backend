using Core.Abstracts.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IUnitOfWorks
{ //IDisposable ile stackoverflow ve memory leak gibi sorunlarin onune geceriz
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ICartRepository CartRepository { get; }
        ICartItemRepository CartItemRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOrderItemRepository OrderItemRepository { get; }
        ISubCategoryRepository SubCategoryRepository { get; }
        IProductImageRepository ProductImageRepository { get; }
        IReviewRepository ReviewRepository { get; }
        void Commit();
    }
}
