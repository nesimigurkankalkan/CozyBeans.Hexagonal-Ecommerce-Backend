using Core.Abstracts.IRepositories;
using Core.Concretes.Entities;
using Data.Context;
using Utils.Generics;

namespace Data.Reposaitories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(ShopContexts db) : base(db) 
        { 
        }
    }
}
