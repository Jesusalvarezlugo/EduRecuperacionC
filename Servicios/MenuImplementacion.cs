using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("#################");
            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. Alta de objeto");
            Console.WriteLine("\"#################\"");
            Console.WriteLine("elija una opcion: ");
            opcion=Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
    }
}
