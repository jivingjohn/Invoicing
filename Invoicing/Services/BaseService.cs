using System;
using System.Linq;
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

        protected ContextRepository<T> Context
        {
            get
            {
                return _contextRepository;
            }
        }


        public bool AddEntry(T baseModel)
        {
            // may want to put some checking here 
            return Context.AddEntity(baseModel);
        }

        public bool RemoveEntry(T baseModel)
        {
            return Context.DeleteEntity(baseModel);
        }

        public T FindEntry(T baseModel)
        {
            return Context.FindEntity(baseModel);
        }

        public IQueryable<T> ListEntries()
        {
            return Context.GetTable();
        }
    }
}
