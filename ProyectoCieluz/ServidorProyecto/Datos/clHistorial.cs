using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServidorProyecto.Datos
{
    public class clHistorial
    {
        public int IdHistorial { get; set; }
        public int idProducto { get; set; }
        public int idCliente { get; set; }

        public DataSet mtdListar()
        {
            string consulta = "SELECT * FROM Historial";
            DataSet dsHistorial = new DataSet();
            clConexion objConexion = new clConexion();
            dsHistorial = objConexion.mtdDesconectado(consulta);
            return dsHistorial;
        }

        public int mtdEliminar()
        {
            string consulta = "Delete from Pedido where IdHistorial=" + IdHistorial + "";
            clConexion objconexion = new clConexion();
            int resultado = objconexion.mtdConectado(consulta);
            return resultado;
        }

    }
}