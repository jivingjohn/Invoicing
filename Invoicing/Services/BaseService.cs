using System;
using Invoicing.DataAccessLayer;
using Invoicing.Interfaces;
using Invoicing.Models;
using Invoicing.Repositories;

namespace Invoicing.Services
{
    public abstract class BaseService<T> : IBaseInterface<T> where T : BaseModel
    {
        private ContextRepository<T> _contextRepository;

        protected BaseService(InvoicingContext invoicingContext)
        {
            _contextRepository = new ContextRepository<T>(invoicingContext);
        }

        protected ContextRepository<T> GetContext()
        {
            return _contextRepository;
        }


        public bool AddEntry(T baseModel)
        {
            // may want to put some checking here 
            return GetContext().AddRow(baseModel);
        }

        public bool RemoveEntry(T baseModel)
        {
            return GetContext().DeleteRow(baseModel);
        }
    }
}
