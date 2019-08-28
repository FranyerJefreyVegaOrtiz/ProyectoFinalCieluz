using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServidorProyecto.Datos
{
    public class clCliente
    {
        public int IdCliente { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Direccion { get; set; }
        public string Clave { get; set; }

        public DataSet mtdListar()
        {
            string consulta = "Select * From Cliente";
            DataSet dsCliente = new DataSet();
            clConexion clConexion = new clConexion();
            dsCliente = clConexion.mtdDesconectado(consulta);
            return dsCliente;
        }

        public int mtdRegistrar(clCliente objCliente)
        {
            string consulta = "insert into Cliente(TipoDocumento,Documento,Nombre,Apellido,Telefono,Correo,Departamento,Municipio,Direccion,Clave)" +
                "Values('" + objCliente.TipoDocumento + "','" + objCliente.Documento + "','" + objCliente.Nombre + "','" + objCliente.Apellido + "','" + objCliente.Telefono + "','" + objCliente.Correo + "','" + objCliente.Departamento + "','" + objCliente.Municipio + "','" + objCliente.Direccion + "','" + objCliente.Clave + "')";
            clConexion clconexion = new clConexion();
            int result = clconexion.mtdConectado(consulta);
            return result;
        }
        public int mtdEditar(clCliente objCliente)
        {
            string consulta = "Update Cliente set Documento='" + Documento + "',Nombre='" + Nombre + "',Apellido='" + Apellido + "',Telefono='" + Telefono + "',Correo='" + Correo + "',Departamento='"+  Departamento +"',Municipio='"+ Municipio +"',Direccion='"+ Direccion +"',Clave='" + Clave + "'" +
                              "where Documento='" + Documento + "'";
            clConexion objConexion = new clConexion();
            int res = objConexion.mtdConectado(consulta);
            return res;
        }
        public int mtdEliminar(clCliente objCliente)
        {
            string consulta = "Delete from Cliente where Documento='" + Documento + "'";
            clConexion objconexion = new clConexion();
            int resul = objconexion.mtdConectado(consulta);
            return resul;
        }

        public DataSet mtdListar2(string Correo, string Clave)
        {
            string consulta = "Select * From Cliente Where Correo='"+  Correo +"'and Clave='"+ Clave +"'";
            DataSet dsCliente = new DataSet();
            clConexion clConexion = new clConexion();
            dsCliente = clConexion.mtdDesconectado(consulta);
            return dsCliente;
        }
    }
}