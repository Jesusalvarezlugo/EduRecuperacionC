using EduRecuperacionC.Controladores;
using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// clase que contiene la operativa del proyecto
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaAlumno()
        {
            try
            {
                AlumnoDto alumno = nuevoAlumno();

                Program.listaAlumnos.Add(alumno);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Metodo para crear un alumno nuevo
        /// </summary>
        /// <returns></returns>
        private AlumnoDto nuevoAlumno()
        {
            AlumnoDto alumno = new AlumnoDto();

            Console.WriteLine("Introduzca el nombre del alumno: ");
            alumno.NombreAlumno = Console.ReadLine();
            Console.WriteLine("Introduzca el primer apellido: ");
            alumno.Apellido1Alumno = Console.ReadLine();
            Console.WriteLine("Introduzca el segundo apellido: ");
            alumno.Apellido2Alumno = Console.ReadLine();
            Console.WriteLine("Introduzca el dni del alumno: ");
            alumno.DniAlumno = Console.ReadLine();
            Console.WriteLine("Introduzca la direccion del alumno: ");
            alumno.DireccionAlumno = Console.ReadLine();
            Console.WriteLine("Introduzca el telefono del alumno: ");
            alumno.TelefonoAlumno = Console.ReadLine();
            Console.WriteLine("Introduzca el email del alumno: ");
            alumno.EmailAlumno = Console.ReadLine();
            alumno.IdAlumno = autoid();

            return alumno;
        }

        /// <summary>
        /// Metodo para autogenerar un nuevo id
        /// </summary>
        /// <returns>id nuevo</returns>
        private long autoid()
        {
            
            
                int tamanioLista = Program.listaAlumnos.Count();
                long nuevoId;

                if (tamanioLista > 0)
                {
                    nuevoId = Program.listaAlumnos[tamanioLista - 1].IdAlumno + 1;
                }
                else
                {
                    nuevoId = 1;
                }

                return nuevoId;
            
            
            
        }

        public void darBajaAlumno()
        {
            string dniAPedir;
            int contador = 0;
            Console.WriteLine("Introduzca el dni del alumno a dar de baja: ");
            dniAPedir = Console.ReadLine();
            AlumnoDto aux=new AlumnoDto();

            foreach(AlumnoDto alumno  in Program.listaAlumnos)
            {
                if (alumno.DniAlumno.Equals(dniAPedir))
                {
                    contador = 1;
                    aux = alumno;
                    break;
                }

                
            }

            if (contador == 0)
            {
                Console.WriteLine("No se encontro al alumno.");
            }
            else
            {
                Program.listaAlumnos.Remove(aux);
            }
            

        }
    }
}
