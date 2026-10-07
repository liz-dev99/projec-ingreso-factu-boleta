using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public class CalculadoraImpuesto : ICalculadoraImpuesto
    {
        //método para obtener el porcentaje de IVA según el tipo
        public decimal ObtenerPorcentaje(TipoIva tipo)
        {
            switch (tipo)
            {
                case TipoIva.General:
                    return 0.19m;
                case TipoIva.Carne:
                    return 0.05m;
                case TipoIva.Harina:
                    return 0.12m;
                case TipoIva.BebidasAltasAzucar:
                    return 0.18m;
                case TipoIva.BebidasBajasAzucar:
                    return 0.10m;
                case TipoIva.AlcoholCerveza:
                    return 0.205m;
                case TipoIva.AlcoholDestilado:
                    return 0.315m;
                default:
                    throw new ArgumentException("Tipo de IVA no válido");
            }
        }
    public decimal  CalcularPrecioConIva(Producto producto)
        {
            decimal precioConIva = producto.Precio;
            foreach (var tipo in producto.TiposIva)
            {
                precioConIva += producto.Precio * ObtenerPorcentaje(tipo);
            }
            return precioConIva;
        }
    }
}
