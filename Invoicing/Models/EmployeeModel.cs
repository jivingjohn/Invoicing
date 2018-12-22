﻿using System.ComponentModel.DataAnnotations;

namespace Invoicing.Models
{
    public class EmployeeModel : BaseModel
    {
        [Required(ErrorMessage = "Please supply your Company Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
