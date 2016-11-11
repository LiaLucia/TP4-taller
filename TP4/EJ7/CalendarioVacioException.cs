using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
    public class CalendarioVacioException:ApplicationException
    {
        public CalendarioVacioException(string eMensaje) : base(eMensaje)
        {

        }
    }
}
