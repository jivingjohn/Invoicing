using System;
using System.Diagnostics;
using Invoicing.Models;
using Microsoft.AspNetCore.Mvc;
using Invoicing.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Invoicing.Controllers
{
    public abstract class BaseController : Controller
    {
        /// <summary>
        /// Adds an entry.
        /// </summary>
        /// <returns>View Result or Redirect to Home if successful</returns>
        /// <param name="baseModel">Model to add.</param>
        /// <param name="baseInterface">Interface to use to add with.</param>
        /// <typeparam name="T">The type of the Model.</typeparam>
        public IActionResult AddEntry<T>(T baseModel, IBaseInterface<T> baseInterface) where T : BaseModel
        {
            if (IsEmptyModel(baseModel))
            {
                // Haven't filled in the form yet
                return View(baseModel);
            }

            if (ModelState.IsValid)
            {
                // Add the Company
                if (baseInterface.AddEntry(baseModel))
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
            return View(baseModel);
        }

        /// <summary>
        /// Tests if the model is empty.
        /// </summary>
        /// <returns><c>true</c>, if empty model, <c>false</c> otherwise.</returns>
        /// <param name="entity">Entity.</param>
        /// <typeparam name="T">The model type.</typeparam>
        public bool IsEmptyModel<T>(T entity) where T : BaseModel
        {
            if (entity == null)
            {
                return true;
            }

            Type type = typeof(T);

            var compare = (T)Activator.CreateInstance(type);

            foreach (System.Reflection.PropertyInfo pi in type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
            {
                object entityValue = type.GetProperty(pi.Name).GetValue(entity, null);
                object compareValue = type.GetProperty(pi.Name).GetValue(compare, null);

                if (entityValue != compareValue)
                {
                    // Something has been filled in
                    return false;
                }
            }

            return true;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
