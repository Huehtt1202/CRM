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
    [Table("PartnerCompany")]
    public class PartnerCompanyEntity : BaseEntity
    {
        [Required(ErrorMessage = "Field is not null")]
        public string CompanyName { get; set; }
        public string TaxCode { get; set; }
        public int Hotline { get; set; }
        public string BusinessSectorActivities { get; set; }
        public string LegalRepresentative { get; set; }
        public string PersonToContact { get; set; } //The person is contacted to counseling service
        public int Numberphone { get; set; }
        public string SourceInformationCustomer { get; set; }
    }
}
