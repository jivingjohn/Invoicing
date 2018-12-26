using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Invoicing.Models;
using Invoicing.Interfaces;

namespace Invoicing.Controllers
{
    public class HomeController : Controller
    {
        private ICompanyInterface _companyInterface;
        private IContractInterface _contractInterface;
        private IEmployeeInterface _employeeInterface;

        public HomeController(ICompanyInterface companyInterface, IContractInterface contractInterface, IEmployeeInterface employeeInterface)
        {
            _companyInterface = companyInterface;
            _contractInterface = contractInterface;
            _employeeInterface = employeeInterface; 
        }

        public IActionResult Index()
        {
            List<IQueryable<BaseModel>> model = new List<IQueryable<BaseModel>>
            {  
                _companyInterface.ListEntries(), 
                _contractInterface.ListEntries(), 
                _employeeInterface.ListEntries() 
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
