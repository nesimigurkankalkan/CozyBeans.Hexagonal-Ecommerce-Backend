using Core.Abstracts.IRepositories;
using Core.Concretes.Entities;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Generics;

namespace Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ShopContexts db) : base(db)
        {
        }
    }
    public class SubCategoryRepository : GenericRepository<Subcategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(ShopContexts db) : base(db)
        {
        }
    }
}
