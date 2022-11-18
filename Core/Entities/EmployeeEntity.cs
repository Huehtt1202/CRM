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
    [Table("EmployeeEntity")]
    public class EmployeeEntity : BaseEntity
    {

        [Required(ErrorMessage = "Field is not null")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public int Numberphone { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<UserEntity> User { get; set; }
        public EmployeeEntity()
        {
            User = new HashSet<UserEntity>();
        }
        public virtual AddressEntity Address { get; set; }

    }
}
