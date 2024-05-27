using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Util
{
    internal static class Utilidades
    {
        public static  string crearNombreLog()
        {
            DateTime fechaActual= DateTime.Today;
            

            string nombreCompletoFichero=String.Concat("log-",fechaActual.ToString("ddMMyy"),".txt");

            return nombreCompletoFichero;
        }
    }
}
