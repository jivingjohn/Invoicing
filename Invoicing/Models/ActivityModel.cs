using System;
using System.ComponentModel.DataAnnotations;

namespace Invoicing.Models
{
    public class ActivityModel : BaseModel
    {
        public ActivityModel()
        {
            // Default to today's date
            Date = DateTime.Now.Date;
        }

        [Display(Name = "Day")]
        public string Day
        {
            get
            {
                return this.Date.DayOfWeek.ToString();
            }
        }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Activity")]
        public string Activity { get; set; }
        [Display(Name = "Hours")]
        public int Hours { get; set; }
    }
}
