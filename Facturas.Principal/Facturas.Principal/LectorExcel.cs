using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public class LectorExcel : ILector
    {
        // Implementa el método ExtraerInformacion para archivos Excel
        public string ExtraerInformacion(string rutaArchivo)
        {
            //extraer información de un archivo Excel
            return $"Texto extraído del archivo Excel: {rutaArchivo}";
        }
    }
}
