using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Contratos;

namespace CapaPersistencia.FabricaDatos
{
    public abstract class FabricaAbstracta
    {
        public static FabricaAbstracta crearInstancia()
        {
            return new FabricaSQLServer();
        }

        public abstract IGestorAccesoDatos crearGestorAccesoDatos();
        public abstract IUsuario crearUsuarioDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IProducto crearCuentaDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IVenta crearTransaccionDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IAlquiler crearMovimientoDAO(IGestorAccesoDatos gestorAccesoDatos);
    }
}
