using System;
using System.Linq;
using Invoicing.DataAccessLayer;
using Invoicing.Models;

namespace Invoicing.Repositories
{
    public class ContextRepository<T> where T : BaseModel
    {
        private InvoicingContext _invoicingContext;

        public ContextRepository(InvoicingContext invoicingContext)
        {
            _invoicingContext = invoicingContext ?? throw new NullReferenceException();
        }

        public IQueryable<T> GetTable()
        {
            return _invoicingContext.Set<T>() ?? Enumerable.Empty<T>().AsQueryable();
        }

        public T FindEntity(T baseModel)
        {
            return _invoicingContext.Set<T>().Find(baseModel.Id);
        }

        public bool AddEntity(T baseModel)
        {
            _invoicingContext.Set<T>().Add(baseModel);
            return SaveChanges();

        }

        public bool EditEntity(T baseModel)
        {
            _invoicingContext.Set<T>().Update(baseModel);
            return SaveChanges(); 
        }

        public bool DeleteEntity(T baseModel)
        {
            _invoicingContext.Set<T>().Remove(baseModel);
            return SaveChanges();
        }

        protected bool SaveChanges()
        {
            try
            {
                _invoicingContext.SaveChanges();
                return true;
            }
            catch
            {
                // Something went wrong
                _invoicingContext.Dispose();
                return false;
            }
        }
    }
}
