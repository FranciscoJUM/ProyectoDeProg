using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    public class ProductoModel
    {
        private Producto[] productos;

        public ProductoModel()
        { }
        public void Add(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("Error, el producto no puede ser null.");
            }

            if (productos == null)
            {
                productos = new Producto[1];
                productos[0] = p;
                return;
            }

            Producto[] tmp = new Producto[productos.Length + 1];
            Array.Copy(productos, tmp, productos.Length);
            tmp[tmp.Length - 1] = p;
            productos = tmp;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

    }
}
