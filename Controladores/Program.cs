using EduRecuperacionC.Dtos;
using EduRecuperacionC.Servicios;
using EduRecuperacionC.Util;

namespace EduRecuperacionC.Controladores
{
    
    class Program
    {
        
        public static string rutaCarpetaLog = "C:\\Users\\Jesús\\source\\repos\\EduRecuperacionC\\Logs\\";
        public static string rutaFicheroLog = String.Concat(rutaCarpetaLog, Utilidades.crearNombreLog());
        public static List<AlumnoDto> listaAlumnos = new List<AlumnoDto>();
        public static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            int opcion;
            bool cerrarMenu = true;

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
