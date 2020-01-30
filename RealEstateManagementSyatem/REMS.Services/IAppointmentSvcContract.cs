using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REMS.DAL;
using REMS.Domain;
namespace REMS.Services
{
    public interface IAppointmentSvcContract
    {
        #region AppointmentDetail
        IList<AppointmentDetail> GetAllAppointments();
        AppointmentDetail GetAppointmentDetailById(int id);
        bool CreateAppointment(params AppointmentDetail[] appointments);
        void UpdateAppointment(params AppointmentDetail[] appointments);
        void RemoveAppointment(params AppointmentDetail[] appointments);
        #endregion
    }
}
