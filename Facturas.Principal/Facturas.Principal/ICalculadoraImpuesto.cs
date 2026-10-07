using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public interface ICalculadoraImpuesto
    {
        //método para obtener el porcentaje de iva según el tipo de iva
        decimal ObtenerPorcentaje(TipoIva tipo);
        decimal CalcularPrecioConIva(Producto producto);
    }
}
