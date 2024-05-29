﻿using EduRecuperacionC.Controladores;
using EduRecuperacionC.Dtos;
using EduRecuperacionC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// Clase para la operativa de los ficheros
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void escribirFicheroLog(string texto)
        {
            StreamWriter escritor = null;
            try
            {
                escritor = new StreamWriter(Program.rutaFicheroLog, true);

                escritor.WriteLine(texto);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al escribir en el fichero");
            }          
            finally
            {
                if( escritor != null )
                {
                    escritor.Close();
                }
            }
            
            
        }

        public void listarAlumnosEnFichero()
        {
            string rutaArchivo = "ListaAlumnos.txt";
            StreamWriter escritor = new StreamWriter(rutaArchivo,true);

            foreach(AlumnoDto alumno in Program.listaAlumnos)
            {
                escritor.WriteLine(alumno.ToString(';'));
            }

            escritor.Close();
        }
    }
}
