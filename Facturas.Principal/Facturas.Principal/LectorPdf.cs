using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public class LectorPdf : ILector
    {
        //Implementación del método ExtraerInformacion de la interfaz ILector
        public string ExtraerInformacion(string rutaArchivo)
        {
            //extraer información de un archivo PDF
            return $"Texto extraído del archivo PDF: {rutaArchivo}";
        }
    }
}
