using Invoicing.Interfaces;
using Invoicing.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Invoicing.Controllers
{
    public class ActivityController : BaseController<ActivityModel>
    {
        private IActivityInterface _activityInterface;
        #region constructor
        public ActivityController(IActivityInterface activityInterface)
        {
            _activityInterface = activityInterface;
        }
        #endregion

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(ActivityModel activityModel)
        {
            return AddEntry(activityModel, _activityInterface);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ActivityModel activityModel)
        {
            return EditEntry(activityModel, _activityInterface);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(ActivityModel activityModel)
        {
            return RequestDeleteEntry(activityModel, _activityInterface);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(ActivityModel activityModel)
        {
            return DeleteEntry(activityModel, _activityInterface);
        }
    }
}
