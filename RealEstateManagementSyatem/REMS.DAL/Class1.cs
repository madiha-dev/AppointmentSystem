using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REMS.Domain;

namespace REMS.DAL
{
    //public class Class1
    //{
    //}
    public interface IAppointmentDetailRepository : IGenericDataRepository<AppointmentDetail>
    {
    }

    public interface IClientRepository : IGenericDataRepository<Client>
    {
    }
    public interface IPropertyRepository : IGenericDataRepository<Property>
    {
    }
    public interface IPropertyTypeRepository : IGenericDataRepository<PropertyType>
    {
    }
    public class AppointmentDetailRepository : GenericDataRepository<AppointmentDetail>, IAppointmentDetailRepository
    {
    }

    public class ClientRepository : GenericDataRepository<Client>, IClientRepository
    {
    }

    public class PropertyRepository : GenericDataRepository<Property>, IPropertyRepository
    {
    }

    public class PropertyTypeRepository : GenericDataRepository<PropertyType>, IPropertyTypeRepository
    {
    }
}
