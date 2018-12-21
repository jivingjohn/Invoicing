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
            return _invoicingContext.Set<T>();
        }

        public T GetEntity(T entity)
        {
            return _invoicingContext.Set<T>().Find(entity.Id);
        }

        public bool AddRow(T entity)
        {
            _invoicingContext.Set<T>().Add(entity);
            return SaveChanges();

        }

        public bool DeleteRow(T entity)
        {
            _invoicingContext.Set<T>().Remove(entity);
            return SaveChanges();
        }

        public bool SaveChanges()
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
