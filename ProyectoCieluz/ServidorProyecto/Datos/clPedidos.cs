using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServidorProyecto.Datos
{
    public class clPedidos
    {
        public int IdPedidos { get; set; }
        public string Cantidad { get; set; }
        public string Talla { get; set; }
        public string PrecioTotal { get; set; }
        public string TipoPago { get; set; }
        public int IdProducto { get; set; }
        public int IdCliente { get; set; }

        public DataSet mtdListar()
        {
            string consulta = "Select * From Pedidos";
            DataSet dsCliente = new DataSet();
            clConexion clConexion = new clConexion();
            dsCliente = clConexion.mtdDesconectado(consulta);
            return dsCliente;
        }

        public int mtdRegistrar(clPedidos objPedidos)
        {
            string consulta = "insert into Pedidos(Cantidad,Talla,PrecioTotal,TipoPago,IdProducto,IdCliente)" +
                "Values('" + objPedidos.Cantidad + "','" + objPedidos.Talla + "','" + objPedidos.PrecioTotal + "','" + objPedidos.TipoPago + "','" + objPedidos.IdProducto + "','" + objPedidos.IdCliente+ "')";
            clConexion clconexion = new clConexion();
            int result = clconexion.mtdConectado(consulta);
            return result;
        }
        public int mtdEditar(clCliente objCliente)
        {
            string consulta = "Update Pedidos set Cantidad='" + Cantidad + "',Talla='" + Talla + "',PrecioTotal='" + PrecioTotal + "',TipoPago='" + TipoPago + "',IdProducto='" + IdProducto + "',IdCliente='" + IdCliente + "'" +
                              "where IdPedidos='" + IdPedidos + "'";
            clConexion objConexion = new clConexion();
            int res = objConexion.mtdConectado(consulta);
            return res;
        }
        public int mtdEliminar(clCliente objCliente)
        {
            string consulta = "Delete from Cliente where IdPedidos='" + IdPedidos + "'";
            clConexion objconexion = new clConexion();
            int resul = objconexion.mtdConectado(consulta);
            return resul;
        }

        public DataSet mtdListarEscritorio()
        {
            string consulta = "Select Pedidos.*, Cliente.*, Producto.* From Producto inner join Pedidos on Producto.IdProducto = Pedidos.IdProducto inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente  where IdPedidos='"+ IdPedidos +"'";
            DataSet dsCliente = new DataSet();
            clConexion clConexion = new clConexion();
            dsCliente = clConexion.mtdDesconectado(consulta);
            return dsCliente;
        }
    }
}