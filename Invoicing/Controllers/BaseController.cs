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

        public bool emptyModel(BaseModel baseModel)
        {
            return !(baseModel == null);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
