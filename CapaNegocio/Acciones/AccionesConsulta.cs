using CapaDatos.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Acciones
{
    public class AccionesConsulta : AccionesBases
    {
        #region Metodos Listar
        public List<Factura> ListFactura()
        {
            return DbLibContext.Facturas.ToList();
        }
        public List<Cliente> ListCliente()
        {
            return DbLibContext.Clientes.ToList();
        }
        public List<Producto> ListProducto()
        { 
            return DbLibContext.Productos.ToList();
        }
        public List<Peso> ListPeso()
        { 
            return DbLibContext.Pesos.ToList();
        }
        public List<Sucursal> ListSucursal()
        { 
            return DbLibContext.Sucursals.ToList();
        }
        public List<Puesto> ListPuesto()
        { 
            return DbLibContext.Puestos.ToList();
        }
        #endregion
    }
}