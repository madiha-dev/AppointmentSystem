using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IAppointmentContract
    {
        #region ManageAppointment

        bool AddNewAppointment(AppointmentDE mod);
        List<AppointmentDE> GetAllAppointments();
        AppointmentDE GetAppointmentById(int id);
        List<LookUP> GetAllPropertyTypes();
        bool DeleteAppointment(int id);

        #endregion

    }
}