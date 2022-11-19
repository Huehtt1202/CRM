using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    [Table("CustomerCare")]
    public class CustomerCareEntity : BaseEntity
    {
        [Required(ErrorMessage = "Field is not null")]
        public string Title { get; set; } //Description content of conversation
        [Required(ErrorMessage = "Field is not null")]
        public string MethodApproach { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string ServiceToConcern { get; set; } //Summary services are concerned by customer
        [Required(ErrorMessage = "Field is not null")]
        public string LevelOfConcern { get; set; } //Update level of customer's concern
        [Required(ErrorMessage = "Field is not null")]
        public string PartnerId { get; set; } //Id of personal customer or PartnerCompany

    }
}
