using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public class Factura : DocumentoTributario
    {
        public string RutCliente { get; set; }
        public Factura (DateTime fechaEmision, string rutCliente) : base(fechaEmision)
        {
            this.RutCliente = rutCliente;
        }
        public override string ObtenerResumen()
        {
            return $"Factura a {RutCliente}, emitida el {FechaEmision}";
        }
    }
}
