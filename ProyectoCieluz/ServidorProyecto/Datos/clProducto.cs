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
            string consulta = "Select Foto, Nombre, Precio, IdProducto, Descripcion From Producto ORDER BY IdProducto DESC ";
            DataSet dsProducto = new DataSet();
            clConexion objConexion = new clConexion();
            dsProducto = objConexion.mtdDesconectado(consulta);
            return dsProducto;
        }
        public DataSet mtdListar2(int IdProducto)
        {
            string consulta = "Select Foto, Nombre, Precio, IdProducto, Descripcion, Color, Diseño From Producto Where IdProducto='"+ IdProducto +"'";
            DataSet dsProducto = new DataSet();
            clConexion objConexion = new clConexion();
            dsProducto = objConexion.mtdDesconectado(consulta);
            return dsProducto;
        }

        List<clProducto> listaPoducto = new List<clProducto>();
        public List<clProducto> mtdListarP()
        {
            clConexion objConexion = new clConexion();
            string consulta = "Select * From Producto";
            DataSet dsProducto = new DataSet();
            dsProducto = objConexion.mtdDesconectado(consulta);
            DataTable tblProducto = dsProducto.Tables["tblDatos"];
            for (int i = 0;i < tblProducto.Rows.Count; i++)
            {
                clProducto objProducto = new clProducto();
                objProducto.IdProducto = int.Parse(tblProducto.Rows[i]["IdProducto"].ToString());
                objProducto.Nombre = tblProducto.Rows[i]["Nombre"].ToString();
                objProducto.Codigo = tblProducto.Rows[i]["Codigo"].ToString();
                objProducto.Foto = tblProducto.Rows[i]["Foto"].ToString();
                objProducto.Precio = tblProducto.Rows[i]["Precio"].ToString();
                objProducto.Color = tblProducto.Rows[i]["Color"].ToString();
                objProducto.Diseño = tblProducto.Rows[i]["Diseño"].ToString();
                objProducto.Descripcion = tblProducto.Rows[i]["Descripcion"].ToString();
                objProducto.IdProducto = int.Parse(tblProducto.Rows[i]["IdProducto"].ToString());
                listaPoducto.Add(objProducto);
            }
            return listaPoducto;
            
        }

        public DataSet mtdListarEscritorio()
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
                "Values ('" + objPr.Nombre + "','" + objPr.Codigo + "', '" + objPr.Foto + "','" + objPr.Precio + "','" + objPr.Color + "','" + objPr.Diseño + "','" + objPr.Descripcion + "','" + objPr.idAdministrador + "')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }

        public int mtdEditar(clProducto objPr)
        {
            string consulta = "Update Producto Set Nombre = '"+objPr.Nombre+ "', Precio = '" + objPr.Precio + "', Color = '" + objPr.Color + "', Diseño = '" + objPr.Diseño + "', Descripcion = '" + objPr.Descripcion + "' where Codigo = '"+objPr.Codigo+"'";
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
        public DataSet mtdListar1()
        {
            string consulta = "Select * From Producto ";
            DataSet dsProducto = new DataSet();
            clConexion objConexion = new clConexion();
            dsProducto = objConexion.mtdDesconectado(consulta);
            return dsProducto;
        }
    }
}