using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Invoicing.Models;
using Invoicing.Services;
using Invoicing.DataAccessLayer;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Invoicing.Controllers
{
    public class CompanyController : BaseController
    {
        private CompanyService _companyService;
        #region constructor
        public CompanyController(InvoicingContext invoicingContext) : base(invoicingContext)
        {
            _companyService = new CompanyService(GetContext());
        }
        #endregion

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CompanyModel companyModel)
        { 
            if(emptyModel(companyModel))
            {
                // Haven't filled in the form yet
                return View(companyModel);
            }

            if (ModelState.IsValid)
            {
                // Add the Company
                if (_companyService.AddEntry(companyModel))
                {
                    // Add was successful
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Error with saving record
                    ModelState.AddModelError("Save Error", "Error saving record, please try again");
                }
            }

            // Display any errors on screen
            return View(companyModel);
        }
    }
}
