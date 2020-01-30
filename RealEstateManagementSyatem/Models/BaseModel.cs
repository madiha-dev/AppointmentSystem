using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract partial class BaseModel
    {
        public BaseModel()
        {

        }
        public int Id { get; set; }
    }
}
