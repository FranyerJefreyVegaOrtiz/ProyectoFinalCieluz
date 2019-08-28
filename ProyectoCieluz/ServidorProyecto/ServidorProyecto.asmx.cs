using ServidorProyecto.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServidorProyecto
{
    /// <summary>
    /// Descripción breve de ServidorProyecto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]

    public class ServidorProyecto : WebService
    {

        [WebMethod]
        public int mtdRegistrarClientes(clCliente ObjCliente)
        {
            clCliente objCli= new clCliente();
            int resul = objCli.mtdRegistrar(ObjCliente);
            return resul;
        }

        [WebMethod]
        public DataSet mtdListarClientes(string Correo, string Clave)
        {
            DataSet dsCliente = new DataSet();
            clCliente objCliente = new clCliente();
            dsCliente = objCliente.mtdListar2(Correo, Clave);
            return dsCliente;
        }

        [WebMethod]
        public DataSet mtdLoginEscritorio(string Correo, string Clave)
        {
            DataSet dsLogin = new DataSet();
            clAdministrador objAdministrador = new clAdministrador();
            dsLogin = objAdministrador.mtdLogin(Correo, Clave);
            return dsLogin;
        }

        [WebMethod]
        public int mtdRegistrarProducto(clProducto objPro)
        {
            clProducto objProducto = new clProducto();
            int resul = objProducto.mtdRegistrar(objPro);
            return resul;
        }

        [WebMethod]
        public int mtdEditarProducto(clProducto objPro)
        {
            clProducto objProducto = new clProducto();
            int resul = objProducto.mtdEditar(objPro);
            return resul;
        }

        [WebMethod]
        public int mtdEliminarProducto(clProducto objPro)
        {
            clProducto objProducto = new clProducto();
            int resul = objProducto.mtdEliminar(objPro);
            return resul;
        }

        [WebMethod]
        public DataSet mtdListarAdmin(clAdministrador ObjAdmin)
        {
            DataSet dsAdmin = new DataSet();
            clAdministrador objAdmin = new clAdministrador();
            dsAdmin = objAdmin.mtdListar();
            return dsAdmin;
        }

        [WebMethod]
        public DataSet mtdListarPro(string Nombre, string Precio)
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListar(Nombre, Precio);
            return dsProducto;
        }

        [WebMethod]
        public DataSet mtdListarProEscritorio()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarEscritorio();
            return dsProducto;
        }

        [WebMethod]
        public DataSet mtdListarCli()
        {
            DataSet dsCliente = new DataSet();
            clCliente objCli = new clCliente();
            dsCliente = objCli.mtdListar();
            return dsCliente;
        }

        [WebMethod]
        public DataSet mtdListarPed()
        {
            DataSet dsPedidos = new DataSet();
            clPedido objPro = new clPedido();
            dsPedidos = objPro.mtdListar();
            return dsPedidos;
        }
    }
}
