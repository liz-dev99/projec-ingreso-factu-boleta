using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public class LectorWhatsapp : ILector
    {
        // Implementación del método ExtraerInformacion 
        public string ExtraerInformacion(string rutaArchivo)
        {
            //extraer información de un archivo WhatsApp
            return $"Texto extraído del archivo WhatsApp: {rutaArchivo}";
        }
    }
}
