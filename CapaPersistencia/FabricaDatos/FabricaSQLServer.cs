using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Contratos;
using CapaPersistencia.ADO_SQLServer;

namespace CapaPersistencia.FabricaDatos
{
    public class FabricaSQLServer : FabricaAbstracta
    {
        public override IGestorAccesoDatos crearGestorAccesoDatos()
        {
            return new GestorSQL();
        }

        public override IUsuario crearUsuarioDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new UsuarioDAO(gestorAccesoDatos);
        }

        public override IProducto crearCuentaDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new ProductoDAO(gestorAccesoDatos);
        }

        public override IVenta crearTransaccionDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new VentaDAO(gestorAccesoDatos);
        }

        public override IAlquiler crearMovimientoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new AlquilerDAO(gestorAccesoDatos);
        }
    }
}
