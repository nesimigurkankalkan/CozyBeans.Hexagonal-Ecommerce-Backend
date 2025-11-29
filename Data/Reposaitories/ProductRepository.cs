using Core.Concretes.Entities;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Generics;

namespace Data.Reposaitories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(ShopContexts db) : base(db) { }
    }
}
