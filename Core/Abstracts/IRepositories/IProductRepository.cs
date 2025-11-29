using Core.Concretes.Entities;
using System.Collections;
using System.Collections.Generic;
using Utils.Generics;

namespace Core.Abstracts.IRepositories
{
    public interface IProductRepository: IGenericRepository<Product> 
    {
        IEnumerable<Product> FindMany();

    }
    public interface ICategoryRepository: IGenericRepository<Category> { }
    public interface IAddressRepository: IGenericRepository<Category> { }
    public interface ICartRepository: IGenericRepository<Category> { }
    public interface ICartItemRepository: IGenericRepository<Category> { }
    public interface IOrderRepository: IGenericRepository<Category> { }
    public interface IOrderItemRepository: IGenericRepository<Category> { }
    public interface IProductImageRepository: IGenericRepository<Category> { }
    public interface IReviewRepository: IGenericRepository<Category> { }
    public interface ISubCategoryRepository: IGenericRepository<Category> { }
    public interface IUserInterfaceRepository: IGenericRepository<Category> { }

}
