using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public class CalculadoraTotalDocumento
    {
        private readonly ICalculadoraImpuesto _calculadoraImpuesto;

        public CalculadoraTotalDocumento(ICalculadoraImpuesto calculadoraImpuesto)
        {
            _calculadoraImpuesto = calculadoraImpuesto;
        }

        public decimal CalcularTotal(DocumentoTributario documento)
        {
            decimal total = 0;
                {
                foreach (var producto in documento.Productos)
                {
                    var impuesto = _calculadoraImpuesto;
                    var precioConIva = impuesto.CalcularPrecioConIva(producto);
                    total += precioConIva;
                }
                return total;
            }
        }
    }
}