using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Field is not null")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string UserPassword { get; set; }
    }
}