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
    public class AlquilerDAO: IAlquiler
    {
        private GestorSQL gestorSQL;

        public AlquilerDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }
    }
}
