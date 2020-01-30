using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Models;
using Translators;
using Domain;

namespace REMS.UI.Controllers
{
    public class AppointmentController : Controller
    {
        #region DataTypes, Constructor
        private AppointmentDAL _appoDal;
        private AppointmentDE _appDE;
        public AppointmentController()
        {
            _appoDal = new AppointmentDAL();
            _appDE = new AppointmentDE();
        }
        #endregion
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }
        #region ActionMethods
        [HttpGet]
        public ActionResult ManageAppointment(string ID, string DBOperation)
        {
            SharedViewModel vm = new SharedViewModel();
            //vm.Appointments = _appoDal.GetAllAppointments().TranslateAppointmentDEList();
            vm.LookUp = _appoDal.GetAllPropertyTypes().TranslateLookUpModel().ToList();
            if(DBOperation == "EDIT")
            {
                int id = Convert.ToInt32(ID);
                vm.Appointment = _appoDal.GetAppointmentById(id).TranslateAppointmentDE();
                vm.Appointment.ConfirmEmail = vm.Appointment.Email;
            }
            return View(vm);
        }
        [HttpGet]
        public ActionResult PartialViewLookup(string ID, string DBOperation="")
        {
            SharedViewModel vm = new SharedViewModel();
            vm.Appointments = _appoDal.GetAllAppointments().TranslateAppointmentDEList();
            if (!string.IsNullOrWhiteSpace(DBOperation))
            {
                if(DBOperation == "DELETE")
                {
                    int id = Convert.ToInt32(ID);
                    if(_appoDal.DeleteAppointment(id))
                    {
                        vm.Appointments = _appoDal.GetAllAppointments().TranslateAppointmentDEList();
                    }
                }
            }
            return PartialView(vm);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ManageAppointment(SharedViewModel mod)
        {
            SharedViewModel vm = new SharedViewModel();
            if (_appoDal.AddNewAppointment(mod.Appointment.TranslateAppointmentModel()))
            {
                vm.Appointments = _appoDal.GetAllAppointments().TranslateAppointmentDEList();
            }
            return RedirectToAction("ManageAppointment");
        }
        [HttpPost]
        public ActionResult PartialViewLookUp(SharedViewModel mod)
        {
            SharedViewModel vm = new SharedViewModel();
            return RedirectToAction("ManageAppointment");
        }
        #endregion
    }
}