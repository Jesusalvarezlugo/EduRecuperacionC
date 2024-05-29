using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// Interfaz para la operativa de los ficheros
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo para escribir en el fichero log
        /// </summary>
        /// <param name="texto"></param>
        public void escribirFicheroLog(string texto);

        public void listarAlumnosEnFichero();
    }
}
