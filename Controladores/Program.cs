using EduRecuperacionC.Dtos;
using EduRecuperacionC.Servicios;
using EduRecuperacionC.Util;

namespace EduRecuperacionC.Controladores
{
    /// <summary>
    /// clase por donde entra el flujo de la aplicacion
    /// </summary>
    class Program
    {
        
        public static string rutaCarpetaLog = "C:\\Users\\Jesús\\source\\repos\\EduRecuperacionC\\Logs\\";
        public static string rutaFicheroLog = String.Concat(rutaCarpetaLog, Utilidades.crearNombreLog());
        public static List<AlumnoDto> listaAlumnos = new List<AlumnoDto>();
        /// <summary>
        /// Metodo principal de la aplicacion
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            OperativaInterfaz oi=new OperativaImplementacion();
            int opcion;
            bool cerrarMenu = true;
            fi.cargaInicial();

            do
            {
                try
                {
                    opcion = mi.mostarMenuYSeleccion();

                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("[INFO] Se cerrara la aplicacion");                          
                            fi.escribirFicheroLog("[INFO] Se cerrara la aplicacion.");                           
                            cerrarMenu = false;
                            break;

                        case 1:
                            Console.WriteLine("[INFO] Se dara alta un objeto nuevo");
                            
                            fi.escribirFicheroLog("[INFO] Se dara alta un objeto nuevo.");
                            oi.darAltaAlumno();

                            foreach(AlumnoDto alumno in listaAlumnos)
                            {
                                Console.WriteLine(alumno.ToString());
                            }
                            break;

                        case 2:
                            fi.escribirFicheroLog("[INFO] Se dara de baja un alumno .");
                            oi.darBajaAlumno();
                            break;

                        case 3:
                            fi.escribirFicheroLog("[INFO] Se escribira en fichero los alumnos .");
                            fi.listarAlumnosEnFichero();
                            break;

                        case 4:
                            fi.escribirFicheroLog("[INFO] Se modificara un campo del alumno .");
                            oi.modificarAlumno();
                            break;

                        default:
                            Console.WriteLine("[ERROR] Opcion introducida no valida");
                            
                            fi.escribirFicheroLog("[ERROR] Opcion introducida no valida.");
                                                     
                            break;
                    }
                }
                catch (Exception ex)
                {
                   
                    fi.escribirFicheroLog("ERROR en alguna funcionalidad de la aplicacion.");                  
                }
                
            } while (cerrarMenu);
            
        }
    }
}
