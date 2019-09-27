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
        public int mtdEditarCliente(clCliente objcli)
        {
            clCliente objCliente = new clCliente();
            int resul = objCliente.mtdEditar(objcli);
            return resul;
        }
        [WebMethod]
        public DataSet mtdCargarCliente(int IdCliente)
        {
            DataSet dsCliente = new DataSet();
            clCliente objCliente = new clCliente();
            dsCliente = objCliente.mtdListarWeb(IdCliente);
            return dsCliente;
        }

        [WebMethod]
        public DataSet mtdListarClientes(int IdCliente)
        {
            DataSet dsCliente = new DataSet();
            clCliente objCliente = new clCliente();
            dsCliente = objCliente.mtdIndex(IdCliente);
            return dsCliente;
        }

        [WebMethod]
        public DataSet mtdListarPedidos()
        {
            DataSet dsPedidos = new DataSet();
            clPedidos objPedidos = new clPedidos();
            dsPedidos = objPedidos.mtdListar();
            return dsPedidos;
        }

        [WebMethod]
        public DataSet mtdListarPedPro()
        {
            DataSet dsPedidos = new DataSet();
            clPedidos objPedidos = new clPedidos();
            dsPedidos = objPedidos.mtdListarProduccion();
            return dsPedidos;
        }

        [WebMethod]
        public DataSet mtdListarPedDes()
        {
            DataSet dsPedidos = new DataSet();
            clPedidos objPedidos = new clPedidos();
            dsPedidos = objPedidos.mtdListarDespachados();
            return dsPedidos;
        }

        [WebMethod]
        public DataSet mtdListarPedEnt()
        {
            DataSet dsPedidos = new DataSet();
            clPedidos objPedidos = new clPedidos();
            dsPedidos = objPedidos.mtdListarEntregados();
            return dsPedidos;
        }

        [WebMethod]
        public DataSet mtdPedidosEscritorio()
        {
            DataSet dsPedidos = new DataSet();
            clPedidos objPedidos = new clPedidos();
            dsPedidos = objPedidos.mtdListarEscritorio();
            return dsPedidos;
        }

        [WebMethod]
        public DataSet mtdProduccionEscritorio()
        {
            DataSet dsPedidos = new DataSet();
            clPedidos objPedidos = new clPedidos();
            dsPedidos = objPedidos.mtdListarProduccion();
            return dsPedidos;
        }
        
        [WebMethod]
        public DataSet mtdDespachadosEscritorio()
        {
            DataSet dsPedidos = new DataSet();
            clPedidos objPedidos = new clPedidos();
            dsPedidos = objPedidos.mtdListarDespachados();
            return dsPedidos;
        }

        [WebMethod]
        public DataSet mtdEntregadosEscritorio()
        {
            DataSet dsPedidos = new DataSet();
            clPedidos objPedidos = new clPedidos();
            dsPedidos = objPedidos.mtdListarEntregados();
            return dsPedidos;
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
        public DataSet mtdLoginWeb(string Correo, string Clave)
        {
            DataSet dsLogin = new DataSet();
            clCliente objCliente = new clCliente();
            dsLogin = objCliente.mtdListar2(Correo, Clave);
            return dsLogin;
        }
        [WebMethod]
        public int mtdRegistrarPedido(clPedidos objPed)
        {
            clPedidos oblPedidos = new clPedidos();
            int resul = oblPedidos.mtdRegistrar(objPed);
            return resul;
        }
        
        [WebMethod]
        public int mtdRegistrarProducto(clProducto objPro)
        {
            clProducto objProducto = new clProducto();
            int resul = objProducto.mtdRegistrar(objPro);
            return resul;
        }

        [WebMethod]
        public int mtdRegistrarPedidos(clPedidos objPed)
        {
            clPedidos objPedidos = new clPedidos();
            int resul = objPedidos.mtdRegistrar(objPed);
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
        public int mtdEditarPedido(clPedidos objPed, int IdPedidos)
        {
            clPedidos objPedido = new clPedidos();
            int resul = objPedido.mtdEditar(objPed, IdPedidos);
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
        public DataSet mtdListarPro(clProducto objProducto)
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListar();
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
        public DataSet mtdListarProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListar();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarProWeb2(int IdProducto)
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListar2(IdProducto);
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
        public DataSet mtdIndex(int IdCliente)
        {
            DataSet dsCliente = new DataSet();
            clCliente objCli = new clCliente();
            dsCliente = objCli.mtdIndex(IdCliente);
            return dsCliente;
        }
        [WebMethod]
        public DataSet mtdListarDTodosProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarDTodos();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarDSencillasProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarDSencillas();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarDAnimalesProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarDAnimales();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarDFloresProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarDFlores();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarDPersonajesProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarDPersonajes();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarDEspecialProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarDEspeciales();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCTodosProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCTodos();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCAmarilloProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCAmarillo();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCAzulProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCAzul();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCBlancoProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCBlanco();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCCafeProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCCafe();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCGrisProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCGris();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCMoradoProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCMorado();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCNaranjaProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCNaranja();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCNegroProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCNegro();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCRojoProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCRojo();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCRosadoProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCRosado();
            return dsProducto;
        }
        [WebMethod]
        public DataSet mtdListarCVerdeProWeb()
        {
            DataSet dsProducto = new DataSet();
            clProducto objPro = new clProducto();
            dsProducto = objPro.mtdListarCVerde();
            return dsProducto;
        }

        [WebMethod]
        public DataSet mtdNotificacionPedido(string FechaXd)
        {
            DataSet dsPed = new DataSet();
            clPedidos objPed = new clPedidos();
            dsPed = objPed.mtdNotificacionPed(FechaXd);
            return dsPed;
        }
    }
    
}
