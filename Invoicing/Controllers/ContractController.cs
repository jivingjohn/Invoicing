using Invoicing.Interfaces;
using Invoicing.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Invoicing.Controllers
{
    public class ContractController : BaseController
    {
        private IContractInterface _contractInterface;
        #region constructor
        public ContractController(IContractInterface contractInterface)
        {
            _contractInterface = contractInterface;
        }
        #endregion

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(ContractModel contractModel)
        {
            return AddEntry(contractModel, _contractInterface);           
        }
    }
}
