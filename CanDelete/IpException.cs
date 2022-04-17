using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanDelete
{
    class IpException: Exception
    {
        public IpException()
        {

        }

        public IpException(string message):base(message)
        {
        }
    }
}
