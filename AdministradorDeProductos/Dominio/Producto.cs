using AdministradorDeProductos.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int  ID {get ; set;}
        public string Nombre{ get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio{ get; set; }
        public string Caducidad { get; set; }
        public UnidadDeMedida Unidaddemedida { get; set; }
    }
}
