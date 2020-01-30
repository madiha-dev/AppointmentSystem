using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract partial class SharedDAL
    {
        public SharedDAL()
        {
            _conStr = ConfigurationManager.ConnectionStrings["REMS_Con_String"].ConnectionString;
        }
        public string _conStr;
    }
}
