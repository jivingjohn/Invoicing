using System.ComponentModel.DataAnnotations;

namespace Invoicing.Models
{
    public class ContractModel : BaseModel
    {
        [Required(ErrorMessage = "Please supply a Buyer Name")]
        [Display(Name = "Buyer Name")]
        public string BuyerName { get; set; }
        [Display(Name = "Buyer Reference")]
        public string BuyerReference { get; set; }
        [Display(Name = "Buyer Address")]
        public string BuyerAddress { get; set; }
        [Display(Name = "Payment Deadline")]
        public string PaymentDeadline { get; set; }
    }
}
