using Core.Abstracts.IRepositories;
using Core.IUnitOfWorks;
using Data.Context;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.SymbolStore;

namespace Data.UnitofWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ShopContexts db;
        public UnitOfWork(ShopContexts context)
        {
            db = context;
        }

        private IProductRepository productRepository;
        public IProductRepository ProductRepository => productRepository = productRepository ?? new Repositories.ProductRepository(db);

        private ICategoryRepository categoryRepository;
        public ICategoryRepository CategoryRepository => categoryRepository = categoryRepository ?? new Repositories.CategoryRepository(db);

        private ICartRepository cartRepository;
        public ICartRepository CartRepository => cartRepository = cartRepository ?? new Repositories.CartRepository(db);

        private ICartItemRepository cartItemRepository;
        public ICartItemRepository CartItemRepository => cartItemRepository = cartItemRepository ?? new Repositories.CartItemRepository(db);

        private IOrderRepository orderRepository;
        public IOrderRepository OrderRepository => orderRepository = orderRepository ?? new Repositories.OrderRepository(db);

        private IOrderItemRepository orderItemRepository;
        public IOrderItemRepository OrderItemRepository => orderItemRepository = orderItemRepository ?? new Repositories.OrderItemRepository(db);

        private ISubCategoryRepository subCategoryRepository;
        public ISubCategoryRepository SubCategoryRepository => subCategoryRepository = subCategoryRepository ?? new Repositories.SubCategoryRepository(db);

        private IProductRepository productImageRepository;
        public IProductRepository ProductImageRepository => productRepository = productRepository ?? new Repositories.ProductRepository(db);

        private IReviewRepository reviewRepository;
        public IReviewRepository ReviewRepository => reviewRepository = reviewRepository ?? new Repositories.ReviewRepository(db);

        public void Commit()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                Dispose();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
