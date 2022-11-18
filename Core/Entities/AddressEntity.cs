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

    [Table("AddressEntity")]
    public class AddressEntity : BaseEntity
    {
        [Required(ErrorMessage = "Field is not null")]
        public string State { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string City { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string District { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string SubDistrict { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string Detail { get; set; }
    }
}
