using System.Linq;
using Invoicing.Models;

namespace Invoicing.Interfaces
{
    public interface IBaseInterface<T> where T : BaseModel
    {
        bool AddEntry(T baseModel);
        bool EditEntry(T baseModel);
        bool RemoveEntry(T baseModel);
        bool IsModified(T baseModel);
        T FindEntry(T baseModel);
        IQueryable<T> ListEntries();
    }
}
