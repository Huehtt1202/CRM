using Core.Entities;
using EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.UniOfWork
{
    public class UnitOfWork
    {
        private EmployeeRepository _employee;
        private UserRepository _user;
        private AddressRepository _address;
        private ApplicationDBContext _dbContext;
        public UnitOfWork(ApplicationDBContext Dbcontext)
        {
            _dbContext = Dbcontext;
        }
        public EmployeeRepository EmpployeeRepo
        {
            get
            {
                if (_employee == null)
                {
                    _employee = new EmployeeRepository(_dbContext);
                }
                return _employee;
            }
        }
        public UserRepository UserRepo
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_dbContext);
                }
                return _user;
            }
        }
        public AddressRepository AddressRepo
        {
            get
            {
                if (_address == null)
                {
                    _address = new AddressRepository(_dbContext);
                }
                return _address;
            }
        }
        public void Savechange()
        {
            _dbContext.SaveChanges();
        }
    }
}
