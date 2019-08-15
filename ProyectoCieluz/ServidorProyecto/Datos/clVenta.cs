using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServidorProyecto.Datos
{
    public class clVenta
    {
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public DateTime Fecha { get; set; }


    public DataSet mtdListar()
    {
        string consulta = "Select * From Venta";
        DataSet dsVenta = new DataSet();
        clConexion objConexion = new clConexion();
        dsVenta = objConexion.mtdDesconectado(consulta);
        return dsVenta;
    }

    public int mtdRegistrar(clVenta objVe)
    {
        string consulta = "Insert Into Venta (Cantidad, Precio, Fecha)" +
            "Values ('" + objVe.Cantidad + "','" + objVe.Precio + "','" + objVe.Fecha + "')";
        clConexion objConexion = new clConexion();
        int resultado = objConexion.mtdConectado(consulta);
        return resultado;
    }

    public int mtdEditar(clVenta objVe)
    {
        string consulta = "Update Venta Set Cantidad = '" + objVe.Cantidad + "', Precio = '" + objVe.Precio + "', Fecha = '" + objVe.Fecha + "'";
        clConexion objConexion = new clConexion();
        int resultado = objConexion.mtdConectado(consulta);
        return resultado;
    }  
    }
}