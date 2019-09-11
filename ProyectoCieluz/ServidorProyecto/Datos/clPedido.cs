using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServidorProyecto.Datos
{
    public class clPedido
    {
        public int IdPedido { get; set; }
        public int Cantidad { get; set; }
        public int Talla { get; set; }
        public DateTime Fecha { get; set; }
        public int PrecioTotal { get; set; }
        public string TipoPago { get; set; }
        public int idProducto { get; set; }
        public int idCliente { get; set; }
        public int idAdministrador { get; set; }

        public DataSet mtdListar()
        {
            string consulta = "Select Pedido.*, Producto.*, Cliente.* From Pedido, Producto, Cliente";
            DataSet dsPedido = new DataSet();
            clConexion objConexion = new clConexion();
            dsPedido = objConexion.mtdDesconectado(consulta);
            return dsPedido;

        }

        public int mtdRegistrar(clPedido objPedido)
        {
            string consulta = "insert into Pedido (Cantidad, Talla, PrecioTotal, TipoPago, idProducto, idCliente, idAdministrador )" +
               "Values('" + Cantidad + "','" + Talla + "','" + PrecioTotal + "','" + TipoPago + "', " + idProducto + ", " + idCliente + ", " + idAdministrador + ")";
            clConexion objconexion = new clConexion();
            int result = objconexion.mtdConectado(consulta);
            return result;
        }


        public int mtdEliminar()
        {
            string consulta = "Delete from Pedido where IdPedido=" + IdPedido + "";
            clConexion objconexion = new clConexion();
            int resultado = objconexion.mtdConectado(consulta);
            return resultado;
        }

        public DataSet mtdListarHoy()
        {
            string consulta = "Select Pedido.*, Producto.*, Cliente.* From Pedido, Producto, Cliente ";
            DataSet dsPedido = new DataSet();
            clConexion objConexion = new clConexion();
            dsPedido = objConexion.mtdDesconectado(consulta);
            return dsPedido;

        }
    }
}