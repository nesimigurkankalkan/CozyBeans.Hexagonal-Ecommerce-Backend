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
    public class CategoryRepositories : GenericRepository<Category>
    {
        public CategoryRepositories(ShopContexts db) : base(db)
        {
        }
    }
}
