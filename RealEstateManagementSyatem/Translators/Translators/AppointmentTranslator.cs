using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Models;
using DAL;

namespace Translators
{
    public static class AppointmentTranslator
    {
        #region Translator
        public static AppointmentModel TranslateAppointmentDE(this AppointmentDE from)
        {
            AppointmentModel to = new AppointmentModel();
            to.Id = from.Id;
            to.AppointmentDate = from.AppointmentDate;
            to.FirstName = from.FirstName;
            to.SurName = from.SurName;
            to.Email = from.Email;
            to.MobileNo = from.MobileNo;
            to.PropertyType = from.PropertyType;
            to.PostCode = from.PostCode;
            to.Address = from.Address;
            to.NoOfBedrooms = from.NoOfBedrooms;
            to.PropertyTypeId = from.PropertyTypeId;

            return to;
        }
        public static List<AppointmentModel> TranslateAppointmentDEList(this List<AppointmentDE> from)
        {
            List<AppointmentModel> to = new List<AppointmentModel>();
            foreach (var item in from)
                to.Add(TranslateAppointmentDE(item));
            return to;
        }
        public static AppointmentDE TranslateAppointmentModel(this AppointmentModel from)
        {
            AppointmentDE to = new AppointmentDE();
            to.Id = from.Id;
            to.AppointmentDate = from.AppointmentDate;
            to.FirstName = from.FirstName;
            to.SurName = from.SurName;
            to.Email = from.Email;
            to.MobileNo = from.MobileNo;
            to.PropertyType = from.PropertyType;
            to.PostCode = from.PostCode;
            to.Address = from.Address;
            to.NoOfBedrooms = from.NoOfBedrooms;
            to.PropertyTypeId = from.PropertyTypeId;

            return to;
        }
        public static List<AppointmentDE> TranslateAppointmentModelList(this List<AppointmentModel> from)
        {
            List<AppointmentDE> to = new List<AppointmentDE>();
            foreach (var item in from)
                to.Add(TranslateAppointmentModel(item));
            return to;
        }

        public static LookUPModel TranslateLookUpModel(this LookUP from)
        {
            LookUPModel to = new LookUPModel();
            to.Id = from.Id;
            to.Name = from.Name;

            return to;
        }
        public static List<LookUPModel> TranslateLookUpModel(this List<LookUP> from)
        {
            List<LookUPModel> to = new List<LookUPModel>();
            foreach (var item in from)
            {
                to.Add(TranslateLookUpModel(item));
            }
            return to;
        }

        #endregion

    }
}
