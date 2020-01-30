using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SharedViewModel
    {
        public SharedViewModel()
        {
            Appointment = new AppointmentModel();
            Appointments = new List<AppointmentModel>();
            LookUp = new List<LookUPModel>();
        }
        public AppointmentModel Appointment { get; set; }
        public List<AppointmentModel> Appointments { get; set; }
        public List<LookUPModel> LookUp { get; set; }
    }
}
