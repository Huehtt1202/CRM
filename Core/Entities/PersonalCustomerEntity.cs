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
    [Table("PersonCustomer")]
    public class PersonalCustomerEntity : BaseEntity
    {
        [Required(ErrorMessage = "Field is not null")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public int Numberphone { get; set; }
        public string BusinessSectorActivities { get; set; }
        public string NoteSummary { get; set; }
        public string SourceInformationCustomer { get; set; }
        public virtual AddressEntity Address { get; set; }
    }
}
