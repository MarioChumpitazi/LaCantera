using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDominio.Entidades;
using CapaDominio.Contratos;

namespace CapaPersistencia.ADO_SQLServer
{
    public class ProductoDAO:IProducto
    {
        private GestorSQL gestorSQL;

        public ProductoDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }
    }
}
