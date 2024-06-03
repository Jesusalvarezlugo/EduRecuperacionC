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
            Console.WriteLine("Introduzca la fecha de nacimiento del alumno: ");
            alumno.FchNacimiento=Convert.ToDateTime(Console.ReadLine());
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

        public void modificarAlumno()
        {
            String dniAPedir;
            int opcionCampo;
            bool cerrarMenu = false;
            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            Console.WriteLine("Introduzca el dni del alumno que desea modificar: ");
            dniAPedir= Console.ReadLine();
            AlumnoDto alumnoAux= new AlumnoDto();

            foreach(AlumnoDto alumno in Program.listaAlumnos)
            {
                if (dniAPedir.Equals(alumno.DniAlumno))
                {
                    do
                    {
                        opcionCampo = mi.menuCampos();

                        switch(opcionCampo)
                        {
                            case 0:
                                Console.WriteLine("Se saldra del menu de modificar campos.");
                                fi.escribirFicheroLog("Se saldra del menu de modificar campos.");
                                cerrarMenu= true;
                                break;

                            case 1:
                                Console.WriteLine("Se modificara el nombre del alumno.");
                                fi.escribirFicheroLog("Se modificara el nombre del alumno.");
                                Console.WriteLine("Introduzca el nombre nuevo del alumno: ");
                                alumno.NombreAlumno = Console.ReadLine();                                          
                                break;

                            case 2:
                                Console.WriteLine("Se modificara el primer apellido del alumno.");
                                fi.escribirFicheroLog("Se modificara el primer apellido del alumno.");
                                Console.WriteLine("Introduzca el primer apellido nuevo del alumno: ");
                                alumno.Apellido1Alumno = Console.ReadLine();
                                break;

                            case 3:
                                Console.WriteLine("Se modificara el segundo apellido del alumno.");
                                fi.escribirFicheroLog("Se modificara el segundo apellido del alumno.");
                                Console.WriteLine("Introduzca el segundo apellido nuevo del alumno: ");
                                alumno.Apellido2Alumno = Console.ReadLine();
                                break;

                            case 4:
                                Console.WriteLine("Se modificara la direccion del alumno.");
                                fi.escribirFicheroLog("Se modificara la direccion del alumno.");
                                Console.WriteLine("Introduzca la direccion nueva del alumno: ");
                                alumno.DireccionAlumno = Console.ReadLine();
                                break;

                            case 5:
                                Console.WriteLine("Se modificara el telefono del alumno.");
                                fi.escribirFicheroLog("Se modificara el telefono del alumno.");
                                Console.WriteLine("Introduzca el telefono nuevo del alumno: ");
                                alumno.TelefonoAlumno = Console.ReadLine();
                                break;

                            case 6:
                                Console.WriteLine("Se modificara el email del alumno.");
                                fi.escribirFicheroLog("Se modificara el email del alumno.");
                                Console.WriteLine("Introduzca el email nuevo del alumno: ");
                                alumno.EmailAlumno = Console.ReadLine();
                                break;

                            case 7:
                                Console.WriteLine("Se modificara la fecha de nacimiento del alumno.");
                                fi.escribirFicheroLog("Se modificara la fecha de nacimiento alumno.");
                                Console.WriteLine("Introduzca la fecha de nacimiento nueva del alumno: ");
                                alumno.FchNacimiento=Convert.ToDateTime(Console.ReadLine());
                                break;

                            default:
                                Console.WriteLine("[ERROR] Opcion iontroducida no valida");
                                fi.escribirFicheroLog("[ERROR] Opcion iontroducida no valida");
                                
                                break;

                                alumnoAux = alumno;
                        }
                    } while (!cerrarMenu);
                }
                else
                {
                    Console.WriteLine("El alumno no existe.");
                    break;
                }
            }



        }
    }
}
