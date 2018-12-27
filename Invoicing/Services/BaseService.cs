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

        public bool EditEntry(T baseModel)
        {
            return Context.EditEntity(baseModel);
        }

        public bool RemoveEntry(T baseModel)
        {
            return Context.DeleteEntity(baseModel);
        }

        public bool IsModified(T baseModel)
        {
            var unModified = FindEntry(baseModel);
            // Compare each property and see if they are the same
            foreach (var property in baseModel.GetType().GetProperties().Where(p => p.CanWrite))
            {
                // Only check settable properties
                Object original = property.GetValue(unModified, null);
                Object toCheck = property.GetValue(baseModel, null);

                // compare the two to see if they 
                if (original != null)
                {
                    if (toCheck != null)
                    {
                        // have something to check
                        if (original != toCheck)
                        {
                            // something has been modified
                            return true;
                        }
                    }
                    else
                    {
                        // our entry has been removed
                        return true;
                    }
                }
                else
                {
                    if (toCheck != null)
                    {
                        // original has been removed
                        return true;
                    }
                }
            }
            // All properties have been checked and no changes found
            return false;
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
