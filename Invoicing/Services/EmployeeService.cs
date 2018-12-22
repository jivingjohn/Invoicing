using System;
using Invoicing.DataAccessLayer;
using Invoicing.Interfaces;
using Invoicing.Models;

namespace Invoicing.Services
{
    public class EmployeeService : BaseService<EmployeeModel>, IEmployeeInterface
    {
        public EmployeeService(InvoicingContext invoicingContext) : base(invoicingContext)
        { }
    }
}
