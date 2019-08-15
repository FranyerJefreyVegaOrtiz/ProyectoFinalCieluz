using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServidorProyecto.Datos
{
    public class clProducto
    {

        public int IdProducto {get; set;}
        public string Nombre {get; set;}
        public string Codigo {get; set;}
        public string Foto {get; set;}
        public string Precio {get; set;}
        public string Color {get; set;}
        public string Diseño {get; set;}
        public string Descripcion {get; set;}
        public int idAdministrador {get; set;}

        public DataSet mtdListar()
        {
            string consulta = "Select * From Producto";
            DataSet dsProducto = new DataSet();
            clConexion objConexion = new clConexion();
            dsProducto = objConexion.mtdDesconectado(consulta);
            return dsProducto;
        }

        public int mtdRegistrar(clProducto objPr)
        {
            string consulta = "Insert Into Producto (Nombre, Codigo, Foto, Precio, Color, Diseño, Descripcion, idAdministrador)" +
                "Values ('" + objPr.Nombre + "','" + objPr.Codigo + "','" + objPr.Foto + "','" + objPr.Precio + "','" + objPr.Color + "','" + objPr.Diseño + "','" + objPr.Descripcion + "','" + objPr.idAdministrador + "')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }

        public int mtdEditar(clProducto objPr)
        {
            string consulta = "Update Producto Set Nombre = '"+objPr.Nombre+ "', Codigo = '" + objPr.Codigo + "', Foto = '" + objPr.Foto + "', Precio = '" + objPr.Precio + "', Color = '" + objPr.Color + "', Diseño = '" + objPr.Diseño + "', Descripcion = '" + objPr.Descripcion + "', idAdministrador = '" + objPr.idAdministrador + "'";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }

        public int mtdEliminar (clProducto objPro)
        {
            string consulta = "Delete From Producto where Codigo = '"+objPro.Codigo+"'";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }
    }
}