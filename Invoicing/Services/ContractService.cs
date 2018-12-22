using System;
using Invoicing.DataAccessLayer;
using Invoicing.Interfaces;
using Invoicing.Models;

namespace Invoicing.Services
{
    public class ContractService : BaseService<ContractModel>, IContractInterface
    {
        public ContractService(InvoicingContext invoicingContext) : base(invoicingContext)
        { }
    }
}
