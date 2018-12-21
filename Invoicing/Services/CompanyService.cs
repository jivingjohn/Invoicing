using System;
using Invoicing.DataAccessLayer;
using Invoicing.Interfaces;
using Invoicing.Models;

namespace Invoicing.Services
{
    public class CompanyService : BaseService<CompanyModel>, ICompanyInterface
    {
        public CompanyService(InvoicingContext invoicingContext) : base(invoicingContext)
        { }
    }
}
