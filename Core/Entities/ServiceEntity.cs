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
    [Table("Service")]
    public class ServiceEntity : BaseEntity
    {
        [Required(ErrorMessage = "Field is not null"),
        Column("SeviceName")]
        public string ServiceCode { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string ServiceTitle { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public float Price { get; set; }
        public string Summary { get; set; }
    }
}
