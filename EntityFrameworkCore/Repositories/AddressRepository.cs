using Core.Entities;
using Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Repositories
{
    public class AddressRepository : Repository<AddressEntity>, IAddressRepository
    {
        ApplicationDBContext _dbContext = new ApplicationDBContext();
        public AddressRepository(ApplicationDBContext Address)
        {
            _dbContext = Address;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
