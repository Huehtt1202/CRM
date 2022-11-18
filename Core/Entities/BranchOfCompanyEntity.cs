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
    [Table("BranchOfCompanyEntity")]
    public class BranchOfCompanyEntity : BaseEntity
    {
        [Required(ErrorMessage = "Field is not null")]
        public string BranchName { get; set; }
        public string Director { get; set; }
        public int Numberphone { get; set; }
        public string BusinessSectorActivities { get; set; }
        public virtual PartnerCompanyEntity PartnerCompany { get; set; }

    }
}
