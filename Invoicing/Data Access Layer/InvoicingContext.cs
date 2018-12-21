using Microsoft.EntityFrameworkCore;
using Invoicing.Models;

namespace Invoicing.DataAccessLayer
{
    public class InvoicingContext : DbContext
    {
        public DbSet<CompanyModel> Companies { get; protected set; }
        public DbSet<ContractModel> Contracts { get; protected set; }
        public DbSet<EmployeeModel> Employees { get; protected set; }

        public InvoicingContext(DbContextOptions<InvoicingContext> options) : base(options)
        {
        }
    }
}
