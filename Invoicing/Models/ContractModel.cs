using System;
namespace Invoicing.Models
{
    public class ContractModel : BaseModel
    {
        public string BuyerReference { get; set; }
        public string BuyerName { get; set; }
        public string BuyerAddress { get; set; }
        public string PaymentDeadline { get; set; }
    }
}
