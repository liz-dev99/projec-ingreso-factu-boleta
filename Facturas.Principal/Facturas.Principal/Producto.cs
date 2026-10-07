using System;
using System.Collections.Generic;
using System.Text;

namespace Facturas.Principal
{
    public class Producto
    {
        // Propiedades sirven para almacenar información sobre el producto, como su nombre, precio y tipos de IVA aplicables.
        public string Nombre { get; set; }
        public decimal Precio {
            get { return _precio; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("El precio no puede ser negativo.");
                }
                _precio = value;
            }
        }
        // Campo privado para almacenar el precio del producto
        private decimal _precio;
        public List<TipoIva> TiposIva { get; set; }
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

    }
}
