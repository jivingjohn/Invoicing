using Invoicing.Interfaces;
using Invoicing.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Invoicing.Controllers
{
    public class CompanyController : BaseController<CompanyModel>
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
            return AddEntry(companyModel, _companyInterface);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CompanyModel companyModel)
        {
            return EditEntry(companyModel, _companyInterface);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(CompanyModel companyModel)
        {
            return RequestDeleteEntry(companyModel, _companyInterface);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(CompanyModel companyModel)
        {
            return DeleteEntry(companyModel, _companyInterface);
        }
    }
}
