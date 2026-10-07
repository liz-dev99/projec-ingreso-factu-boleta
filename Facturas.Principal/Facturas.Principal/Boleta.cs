using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public class Boleta : DocumentoTributario
    {
        // Constructor de la clase Boleta que recibe la fecha de emisión como parámetro
        public Boleta(DateTime fechaEmision) : base(fechaEmision)
        {
        }
        public override string ObtenerResumen()
        {
            return $"Boleta emitida el {FechaEmision}";
        }
    }
}
