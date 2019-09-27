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
        public string Estado { get; set; }

        public DataSet mtdListar()
        {
            string consulta = "Select * From Pedidos";
            DataSet dsCliente = new DataSet();
            clConexion clConexion = new clConexion();
            dsCliente = clConexion.mtdDesconectado(consulta);
            return dsCliente;
        }

        string Fecha = DateTime.Now.ToString("yyyy/MM/dd");

        public int mtdRegistrar(clPedidos objPedidos)
        {
            string consulta = "insert into Pedidos(Cantidad,Talla,PrecioTotal,TipoPago,IdProducto,IdCliente,Fecha)" +
                "Values('" + objPedidos.Cantidad + "','" + objPedidos.Talla + "','" + objPedidos.PrecioTotal + "','" + objPedidos.TipoPago + "','" + objPedidos.IdProducto + "','" + objPedidos.IdCliente+ "', '" + Fecha + "' )";
            clConexion clconexion = new clConexion();
            int result = clconexion.mtdConectado(consulta);
            return result;
        }

        public int mtdEditar(clPedidos objPed, int IdPedidos)
        {
            string consulta = "Update Pedidos set  Cantidad='" + objPed.Cantidad + "',Talla='" + objPed.Talla + "',PrecioTotal='" + objPed.PrecioTotal + "',TipoPago='" + objPed.TipoPago + "',IdProducto='" + objPed.IdProducto + "',IdCliente='" + objPed.IdCliente + "', Estado = '"+ objPed.Estado + "' where IdPedidos = '"+IdPedidos+"'";
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
            string consulta = "Select Pedidos.*, Cliente.*, Producto.* From Producto inner join Pedidos on Producto.IdProducto = Pedidos.IdProducto inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente  where Estado = ''";
            DataSet dsCliente = new DataSet();
            clConexion clConexion = new clConexion();
            dsCliente = clConexion.mtdDesconectado(consulta);
            return dsCliente;
        }

        public DataSet mtdNotificacionPed(string Fecha)
        {
            string consulta = "Select * From Pedidos Where Fecha = '"+ Fecha +"'";
            DataSet dsCliente = new DataSet();
            clConexion clConexion = new clConexion();
            dsCliente = clConexion.mtdDesconectado(consulta);
            return dsCliente;
        }

        public DataSet mtdListarProduccion()
        {
            string consulta = "Select Pedidos.*, Cliente.*, Producto.* From Producto inner join Pedidos on Producto.IdProducto = Pedidos.IdProducto inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente where Estado = 'Produccion'";
            DataSet dsCliente = new DataSet();
            clConexion clConexion = new clConexion();
            dsCliente = clConexion.mtdDesconectado(consulta);
            return dsCliente;
        }

        public DataSet mtdListarDespachados()
        {
            string consulta = "Select Pedidos.*, Cliente.*, Producto.* From Producto inner join Pedidos on Producto.IdProducto = Pedidos.IdProducto inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente where Estado = 'Despachados'";
            DataSet dsCliente = new DataSet();
            clConexion clConexion = new clConexion();
            dsCliente = clConexion.mtdDesconectado(consulta);
            return dsCliente;
        }

        public DataSet mtdListarEntregados()
        {
            string consulta = "Select Pedidos.*, Cliente.*, Producto.* From Producto inner join Pedidos on Producto.IdProducto = Pedidos.IdProducto inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente where Estado = 'Entregados'";
            DataSet dsCliente = new DataSet();
            clConexion clConexion = new clConexion();
            dsCliente = clConexion.mtdDesconectado(consulta);
            return dsCliente;
        }
    }
}