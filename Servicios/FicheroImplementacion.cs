using EduRecuperacionC.Controladores;
using EduRecuperacionC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void escribirFicheroLog(string texto)
        {
            StreamWriter escritor = new StreamWriter(Program.rutaFicheroLog);

            escritor.WriteLine(texto);
            escritor.Close();
        }
    }
}
