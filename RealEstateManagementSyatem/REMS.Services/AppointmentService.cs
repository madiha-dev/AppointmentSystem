using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REMS.Domain;
using REMS.DAL;

namespace REMS.Services
{
    public class AppointmentService : IAppointmentSvcContract
    {
        #region Variables , ctor

        private IAppointmentDetailRepository _appSvc;
        public AppointmentService()
        {
            _appSvc = new AppointmentDetailRepository();
        }
        #endregion

        public bool CreateAppointment(params AppointmentDetail[] appointments)
        {
            bool retVal = false;
            try
            {
                _appSvc.Add(appointments);
                retVal = true;
            }
            catch(Exception ex)
            {
                retVal = false;
            }
            return retVal;
        }

        public IList<AppointmentDetail> GetAllAppointments()
        {
            return _appSvc.GetAll();
        }

        public AppointmentDetail GetAppointmentDetailById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveAppointment(params AppointmentDetail[] appointments)
        {
            throw new NotImplementedException();
        }

        public void UpdateAppointment(params AppointmentDetail[] appointments)
        {
            throw new NotImplementedException();
        }
    }
}
