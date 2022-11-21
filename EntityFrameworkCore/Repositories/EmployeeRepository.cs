using Core.Entities;
using Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Repositories
{
    public class EmployeeRepository : Repository<EmployeeEntity>, IEmployeeRepository
    {
        private ApplicationDBContext _dbContext;
        public EmployeeRepository(ApplicationDBContext Employee)
        {
            _dbContext = Employee;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Insert(EmployeeEntity Employee)
        {
            throw new NotImplementedException();
        }
    }
}
