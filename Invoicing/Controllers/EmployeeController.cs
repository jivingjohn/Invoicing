using Invoicing.Interfaces;
using Invoicing.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Invoicing.Controllers
{
    public class EmployeeController : BaseController
    {
        private IEmployeeInterface _employeeInterface;
        #region constructor
        public EmployeeController(IEmployeeInterface employeeInterface)
        {
            _employeeInterface = employeeInterface;
        }
        #endregion

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(EmployeeModel employeeModel)
        {
            return AddEntry(employeeModel, _employeeInterface);           
        }
    }
}
