using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Invoicing.Models
{
    public class CompanyModel : BaseModel
    {
        [Required (ErrorMessage="Please supply your Company Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Telephone")]
        public string Telephone { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Company Number")]
        public string CompanyNumber { get; set; }
        [Display(Name = "Vat Number")]
        public string VatNumber { get; set; }
        [Display(Name = "Bank Name")]
        public string BankName { get; set; }
        [Display(Name = "Sort Code")]
        public string SortCode { get; set; }
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
    }
}
