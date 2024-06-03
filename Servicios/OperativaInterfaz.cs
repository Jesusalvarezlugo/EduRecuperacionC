using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo para dar de alta a un alumno
        /// </summary>
        public void darAltaAlumno();
        /// <summary>
        /// Metodo para dar de baja a un alumno
        /// </summary>
        public void darBajaAlumno();
        /// <summary>
        /// metodo para modificar un alumno.
        /// </summary>
        public void modificarAlumno();
    }
}
