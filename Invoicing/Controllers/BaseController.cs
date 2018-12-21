using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Invoicing.Models;
using System.Diagnostics;
using Invoicing.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Invoicing.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly InvoicingContext _invoicingContext;

        public BaseController(InvoicingContext invoicingContext)
        {
            _invoicingContext = invoicingContext;    
        }

        public InvoicingContext GetContext()
        {
            return _invoicingContext; 
        }

        public bool emptyModel<T>(T entity) where T : BaseModel
        {
            if (entity == null)
            {
                return true;
            }

            Type type = typeof(T);

            var compare = (T)Activator.CreateInstance(type);

            foreach (System.Reflection.PropertyInfo pi in type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
            {
                object entityValue = type.GetProperty(pi.Name).GetValue(entity, null);
                object compareValue = type.GetProperty(pi.Name).GetValue(compare, null);

                if (entityValue != compareValue)
                {
                    // Something has been filled in
                    return false;
                }
            }

            return true;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
