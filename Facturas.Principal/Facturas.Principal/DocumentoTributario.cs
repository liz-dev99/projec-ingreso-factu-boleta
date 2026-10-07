using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public abstract class DocumentoTributario
    {
        public DateTime FechaEmision { get; set; }
        public List<Producto> Productos { get; set; }
        public abstract string ObtenerResumen();
        public DocumentoTributario( DateTime fechaEmision)
        {
            FechaEmision = fechaEmision;
            Productos = new List<Producto>();
        }
    }
}
