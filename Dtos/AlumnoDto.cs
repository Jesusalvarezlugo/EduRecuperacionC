using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Dtos
{
    /// <summary>
    /// Clase de la entidad alumno
    /// </summary>
    internal class AlumnoDto
    {
        //Atributos

        long idAlumno;
        string nombreAlumno = "aaaaa";
        string apellido1Alumno = "aaaaa";
        string apellido2Alumno = "aaaaa";
        string dniAlumno = "aaaaa";
        string direccionAlumno = "aaaaa";
        string telefonoAlumno = "aaaaa";
        string emailAlumno = "aaaaa";

        //Getters y Setters
        public long IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string Apellido1Alumno { get => apellido1Alumno; set => apellido1Alumno = value; }
        public string Apellido2Alumno { get => apellido2Alumno; set => apellido2Alumno = value; }
        public string DniAlumno { get => dniAlumno; set => dniAlumno = value; }
        public string DireccionAlumno { get => direccionAlumno; set => direccionAlumno = value; }
        public string TelefonoAlumno { get => telefonoAlumno; set => telefonoAlumno = value; }
        public string EmailAlumno { get => emailAlumno; set => emailAlumno = value; }

        override
            public string ToString()
        {
            string texto = "DNI: "+this.dniAlumno+" - "+this.nombreAlumno;
            return texto;
        }

        public string ToString(char puntoYComa)
        {
            //Dni;Nombre
            
            string texto=String.Concat(this.dniAlumno,puntoYComa,this.nombreAlumno);
            return texto;
        }
    }
}
