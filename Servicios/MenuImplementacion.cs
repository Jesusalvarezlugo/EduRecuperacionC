using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuCampos()
        {
            
                int opcion;
                Console.WriteLine("Elija el campo a modificar");
                Console.WriteLine("1.Nombre");
                Console.WriteLine("2.1 Apellido");
                Console.WriteLine("2.2 Apellido");
                Console.WriteLine("4.Direccion");
                Console.WriteLine("5.Telofono");
                Console.WriteLine("6.email");
                Console.WriteLine("7. fecha de nacimiento");
                Console.WriteLine("0.salir");
                opcion = Console.ReadKey(true).KeyChar - ('0');

                return opcion;
            
        }

        public int mostarMenuYSeleccion()
        {
            
            try
            {
                int opcion;

                Console.WriteLine("#################");
                Console.WriteLine("0. Cerrar Menu");
                Console.WriteLine("1. Alta de alumno nuevo");
                Console.WriteLine("2. baja de alumno ");
                Console.WriteLine("3. escribir alumnos en fichero ");
                Console.WriteLine("4. Modificar campo del alumno. ");
                Console.WriteLine("#################");
                Console.WriteLine("elija una opcion: ");
                opcion = Console.ReadKey(true).KeyChar - ('0');
                return opcion;
            }
            catch (Exception ex)
            {
                throw;
            }
            

            

            
        }
    }
}
