using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract partial class BaseDomain
    {
        public BaseDomain()
        {

        }
        public int Id { get; set; }
    }
}
