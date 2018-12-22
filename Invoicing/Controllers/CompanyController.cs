using Invoicing.Interfaces;
using Invoicing.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Invoicing.Controllers
{
    public class CompanyController : BaseController
    {
        private ICompanyInterface _companyInterface;
        #region constructor
        public CompanyController(ICompanyInterface companyInterface)
        {
            _companyInterface = companyInterface;
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
                if (_companyInterface.AddEntry(companyModel))
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
