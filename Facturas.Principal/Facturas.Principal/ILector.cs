using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public interface ILector
    {
        // Método para extraer información de un archivo
        string ExtraerInformacion(string rutaArchivo);
    }
}
