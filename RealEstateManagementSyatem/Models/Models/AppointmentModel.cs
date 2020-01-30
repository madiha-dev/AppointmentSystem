using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Models
{
    public class AppointmentModel : BaseModel
    {
        public AppointmentModel()
        {
            Names = new List<LookUPModel>();
        }
        public List<LookUPModel> Names { get; set; }

        [DataType(DataType.PostalCode)]
        [RegularExpression(@"^\d{6}(-\d{4})?$",
                           ErrorMessage = "Not a valid Post Code")]
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string NoOfBedrooms { get; set; }
        public int PropertyTypeId { get; set; }
        public string PropertyType { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Sur Name is required")]
        [MaxLength(20)]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Email is Requirde")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Email is Requirde")]
        [Compare("Email")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Contact number is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                           ErrorMessage = "Not a valid Mobile number")]
        public string MobileNo { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy HH:mm}",
            ApplyFormatInEditMode = true)]
        public DateTime AppointmentDate { get; set; }
    }
}
