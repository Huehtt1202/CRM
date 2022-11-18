using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace EntityFrameworkCore
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("CRM")
        {
            // Database.SetInitializer(new DropCreateDatabaseAlways<StudentModels>());

            //var initializer = new MigrateDatabaseToLatestVersion<ApplicationDBContext, Migrations.Configuration>();
            //Database.SetInitializer(initializer);
        }
        public virtual DbSet<AddressEntity> Address { get; set; }
        public virtual DbSet<BranchOfCompanyEntity> BranchOfCompany { get; set; }
        public virtual DbSet<CustomerCareEntity> CustomerCare { get; set; }
        public virtual DbSet<EmployeeEntity> Employee { get; set; }
        public virtual DbSet<PartnerCompanyEntity> PartnerCompany { get; set; }
        public virtual DbSet<PersonalCustomerEntity> PersonalCustomer { get; set; }
        public virtual DbSet<ServiceEntity> Service { get; set; }
        public virtual DbSet<UserEntity> User { get; set; }

    }
}
