using System;
using System.ComponentModel.DataAnnotations;

namespace Invoicing.Models
{
    public abstract class BaseModel
    {
        [UIHint("Hidden")]
        Guid _Id;

        public virtual Guid Id
        {
            get
            {
                return _Id;
            }
            protected set
            {
                _Id = value;
            }
        }

        public string CreateText
        {
            get
            {
                return string.Concat("Create a new ", ModelName);
            }
        }

        public string UpdateText
        {
            get
            {
                return string.Concat("Update ", ModelName, " details");
            }
        }

        public string DeleteText
        {
            get
            {
                return string.Concat("Delete this ", ModelName);
            }
        }

        public ControllerDetails AddForm
        {
            get
            {
                return new ControllerDetails 
                { 
                    Action = "Add", 
                    Controller = ModelName 
                };
            }
        }

        public ControllerDetails DeleteForm
        {
            get
            {
                return new ControllerDetails
                {
                    Action = "Delete",
                    Controller = ModelName
                };
            }
        }

        public ControllerDetails ConfirmDeleteForm
        {
            get
            {
                return new ControllerDetails
                {
                    Action = "ConfirmDelete",
                    Controller = ModelName
                };
            }
        }

        public string ModelName
        {
            get
            {
                return this.GetType().Name.Replace("Model", "");
            }
        }

        public bool IsTransient()
        {
            return this.Id == default(Guid);
        }
    }

    public class ControllerDetails
    {
        public string Action { get; set; }
        public string Controller { get; set; }
        public string ButtonName { get { return string.Concat(Action, "Button"); } }
    }
}
