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
    public class ServidorProyecto : System.Web.Services.WebService
    {

        [WebMethod]
        public int mtdRegistrarClientes(clCliente ObjCliente)
        {
            clCliente objCli= new clCliente();
            int resul = objCli.mtdRegistrar(ObjCliente);
            return resul;
        }

        [WebMethod]
        public DataSet mtdListarClientes()
        {
            DataSet dsCliente = new DataSet();
            clCliente objCliente = new clCliente();
            dsCliente = objCliente.mtdListar();
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

    }
}
