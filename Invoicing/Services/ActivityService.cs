using System;
using Invoicing.DataAccessLayer;
using Invoicing.Interfaces;
using Invoicing.Models;

namespace Invoicing.Services
{
    public class ActivityService : BaseService<ActivityModel>, IActivityInterface
    {
        public ActivityService(InvoicingContext invoicingContext) : base(invoicingContext)
        { }
    }
}
