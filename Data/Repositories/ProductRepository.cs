using Core.Abstracts.IRepositories;
using Core.Concretes.Entities;
using Data.Context;
using System.Collections.Generic;
using Utils.Generics;

namespace Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ShopContexts db) : base(db) { }

    }
}
