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
        DateTime fchNacimiento= DateTime.Now;

        //Getters y Setters
        public long IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string Apellido1Alumno { get => apellido1Alumno; set => apellido1Alumno = value; }
        public string Apellido2Alumno { get => apellido2Alumno; set => apellido2Alumno = value; }
        public string DniAlumno { get => dniAlumno; set => dniAlumno = value; }
        public string DireccionAlumno { get => direccionAlumno; set => direccionAlumno = value; }
        public string TelefonoAlumno { get => telefonoAlumno; set => telefonoAlumno = value; }
        public string EmailAlumno { get => emailAlumno; set => emailAlumno = value; }
        public DateTime FchNacimiento { get => fchNacimiento; set => fchNacimiento = value; }

        override
            public string ToString()
        {
            string texto = "DNI: "+this.dniAlumno+" - "+this.nombreAlumno;
            return texto;
        }

        public string ToString(char puntoYComa)
        {
            //Dni;Nombre <-- orden obligatorio
            
            string texto=String.Concat(this.dniAlumno,puntoYComa,this.nombreAlumno,puntoYComa,this.apellido1Alumno,puntoYComa,this.apellido2Alumno,puntoYComa,this.direccionAlumno,puntoYComa,this.telefonoAlumno,puntoYComa,this.emailAlumno,puntoYComa,this.fchNacimiento);
            return texto;
        }
    }
}
