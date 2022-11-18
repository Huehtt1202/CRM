using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Base;

namespace Core.Entities
{
    [Table("User")]
    public class UserEntity : BaseEntity
    {
        [Required(ErrorMessage = "Field is not null")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string UserPassword { get; set; }
        public virtual ICollection<EmployeeEntity> Employee { get; set; }
        public UserEntity()
        {
            Employee = new HashSet<EmployeeEntity>();
        }
    }
}
