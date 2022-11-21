using Core.Entities;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace EntityFrameworkCore
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("CRM")
        {
            // Database.SetInitializer(new DropCreateDatabaseAlways<StudentModels>());

            //var initializer = new MigrateDatabaseToLatestVersion<ApplicationDBContext, Migrations.Configuration>();
            //Database.SetInitializer(initializer);
        }
        public virtual DbSet<AddressEntity> Address_ { get; set; }
        public virtual DbSet<BranchOfCompanyEntity> BranchOfCompany_ { get; set; }
        public virtual DbSet<CustomerCareEntity> CustomerCare_ { get; set; }
        public virtual DbSet<EmployeeEntity> Employee_ { get; set; }
        public virtual DbSet<PartnerCompanyEntity> PartnerCompany_ { get; set; }
        public virtual DbSet<PersonalCustomerEntity> PersonalCustomer_ { get; set; }
        public virtual DbSet<ServiceEntity> Service_ { get; set; }
        public virtual DbSet<UserEntity> User_ { get; set; }

        
    }
}
