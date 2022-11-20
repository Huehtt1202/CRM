using Core.Entities;
using Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepositories
{
    public interface ICustomerCareRepository : IDisposable, IRepository<PersonalCustomerEntity>
    {
    }
}
