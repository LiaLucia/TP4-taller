using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{/// <summary>
/// Excepcion que se produce cuando un calendario no posee eventos
/// </summary>
    public class CalendarioVacioException:ApplicationException
    {
        public CalendarioVacioException(string eMensaje) : base(eMensaje)
        {

        }
    }
}
