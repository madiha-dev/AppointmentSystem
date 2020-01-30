using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AppointmentDE : BaseDomain
    {
        public AppointmentDE()
        {
            Names = new List<LookUP>();
        }
        public List<LookUP> Names { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string NoOfBedrooms { get; set; }
        public string PropertyType { get; set; }
        public int PropertyTypeId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public DateTime AppointmentDate { get; set; }

    }
}
