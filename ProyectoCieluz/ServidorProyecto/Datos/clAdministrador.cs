using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServidorProyecto.Datos
{
    public class clAdministrador
    {
        public int IdAdministrador { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }

        public DataSet mtdListar()
        {
            string consulta = "Select * From Administrador";
            DataSet dsAdministrador = new DataSet();
            clConexion clConexion = new clConexion();
            dsAdministrador = clConexion.mtdDesconectado(consulta);
            return dsAdministrador;
        }

        public int mtdRegistrar(clAdministrador objAdministrador)
        {
            string consulta = "insert into Administrador(Documento,Nombre,Apellido,Telefono,Correo,Clave)" +
                "Values('" + Documento + "','" + Nombre + "','" + Apellido + "','" + Telefono + "','" + Correo + "','" + Clave + "')";
            clConexion clconexion = new clConexion();
            int result = clconexion.mtdConectado(consulta);
            return result;
        }
        public int mtdEditar()
        {
            string consulta = "Update Administrador set Documento='" + Documento + "',Nombre='"+ Nombre +"',Apellido='"+ Apellido +"',Telefono='"+ Telefono +"',Correo='"+ Correo +"',Clave='"+ Clave +"'"+
                              "where Documento='" + Documento + "'";
            clConexion objConexion = new clConexion();
            int res = objConexion.mtdConectado(consulta);
            return res;
        }
        public int mtdEliminar()
        {
            string consulta = "Delete from Administrador where Documento='" + Documento + "'";
            clConexion objconexion = new clConexion();
            int resul = objconexion.mtdConectado(consulta);
            return resul;
        }

        public DataSet mtdLogin(string Correo, string Clave)
        {
            string consulta = "Select Correo, Clave From Administrador where Correo = '"+ Correo + "' and Clave = '" + Clave + "'";
            DataSet dsAdministrador = new DataSet();
            clConexion clConexion = new clConexion();
            dsAdministrador = clConexion.mtdDesconectado(consulta);
            return dsAdministrador;
        }
    }
}