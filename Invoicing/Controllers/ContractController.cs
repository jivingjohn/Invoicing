using Invoicing.Interfaces;
using Invoicing.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Invoicing.Controllers
{
    public class ContractController : BaseController<ContractModel>
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ContractModel contractModel)
        {
            return EditEntry(contractModel, _contractInterface);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(ContractModel contractModel)
        {
            return RequestDeleteEntry(contractModel, _contractInterface);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(ContractModel contractModel)
        {
            return DeleteEntry(contractModel, _contractInterface);
        }
    }
}
