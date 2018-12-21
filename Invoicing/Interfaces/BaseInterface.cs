using System;
using Invoicing.Models;

namespace Invoicing.Interfaces
{
    public interface IBaseInterface<T> where T : BaseModel
    {
        bool AddEntry(T baseModel);
        bool RemoveEntry(T baseModel);
    }
}
