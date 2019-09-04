﻿using ServidorProyecto.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebCieluz
{
    public partial class Formulario_web2 : System.Web.UI.Page
    {
        ServicioWebCieluz.ServidorProyectoSoapClient miservice = new ServicioWebCieluz.ServidorProyectoSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            mtdCargarPto();
            //string Nombre = Request.Form["Nombre"];
            ////string Precio = Request.Form["Precio"];

            //DataSet dsProductos = new DataSet();
            //dsProductos = miservice.mtdListarProWeb();
            //DataTable tblProductos = dsProductos.Tables["tblDatos"];
            //txtNombre.DataSource = tblProductos;
            //txtNombre.DataValueField = "Nombre";
            //txtNombre.DataTextField = "IdProducto";
            //txtNombre.DataBind();
        }
        protected void mtdCargarPto()
        {
            try
            {

                ServicioWebCieluz.clProducto objProducto = new ServicioWebCieluz.clProducto();
                DataSet dsProucto = new DataSet();
                dsProucto = miservice.mtdListarProWeb();
                DataTable tblProducto = dsProucto.Tables["tblDatos"];
                //var dato = tblProducto.Rows[0][3];
                //dato = Session["IdProducto"].ToString();
                //tblProducto.Rows[0]["imgSalida"] = dato;
                //Response.Redirect("DetalleProductos.aspx" + dato);
                // Image1.ImageUrl = "data:image/jpg;base64," + tblProducto.Rows[0][0].ToString();

                Repeater1.DataSource = tblProducto;
                Repeater1.DataBind();
            }
            catch
            {

            }
        }
        public System.Drawing.Image RedimencionarImagen (System.Drawing.Image ImagenOriginal, int Alto)
        {
            var Radio = (double)Alto / ImagenOriginal.Height;
            var NuevoAncho = (int)(ImagenOriginal.Width * Radio);
            var NuevoAlto = (int)(ImagenOriginal.Height * Radio);
            var NuevaImagenRedimencional = new Bitmap(NuevoAncho, NuevoAlto);
            var g = Graphics.FromImage(NuevaImagenRedimencional);
            g.DrawImage(ImagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            return NuevaImagenRedimencional;
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            
        }

        
    }
}