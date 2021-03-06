﻿using Invoicing.Interfaces;
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
            return AddEntry(companyModel, _companyInterface);           
        }
    }
}
