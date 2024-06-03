using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Util
{
    /// <summary>
    /// clase de utilidades
    /// </summary>
    internal static class Utilidades
    {
        /// <summary>
        /// metodo que crea el nombre del fichero log
        /// </summary>
        /// <returns>el nombre completo del fichero</returns>
        public static  string crearNombreLog()
        {
            string nombreCompletoFichero="9";
            try
            {
                DateTime fechaActual = DateTime.Today;

                 nombreCompletoFichero = String.Concat("log-", fechaActual.ToString("ddMMyy"), ".txt");

                
            }catch (Exception ex)
            {
                throw;
            }

            return nombreCompletoFichero;


        }
    }
}
