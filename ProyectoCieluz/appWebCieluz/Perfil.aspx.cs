using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebCieluz
{
    public partial class Formulario_web22 : System.Web.UI.Page
    {
        ServicioWebCieluz.ServidorProyectoSoapClient Servicio = new ServicioWebCieluz.ServidorProyectoSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblid.Text = Session["IdCliente"].ToString();
            int IdCliente = int.Parse(lblid.Text);
            DataSet dsCliente = new DataSet();
            dsCliente = Servicio.mtdCargarCliente(IdCliente);
            DataTable tblCliente = dsCliente.Tables["tblDatos"];
            cmbTipo.SelectedValue = tblCliente.Rows[0][0].ToString();
            txtDocumento.Text = tblCliente.Rows[0][1].ToString();
            txtNombre.Text = tblCliente.Rows[0][2].ToString();
            txtApellido.Text = tblCliente.Rows[0][3].ToString();
            txtTelefono.Text = tblCliente.Rows[0][4].ToString();
            txtCorreo.Text = tblCliente.Rows[0][5].ToString();
            txtDepartamento.Text = tblCliente.Rows[0][6].ToString();
            txtMuni.Text = tblCliente.Rows[0][7].ToString();
            txtDireccion.Text = tblCliente.Rows[0][8].ToString();
            txtClave.Text = tblCliente.Rows[0][9].ToString();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ServicioWebCieluz.clCliente objCliente = new ServicioWebCieluz.clCliente();
            objCliente.TipoDocumento = cmbTipo.SelectedValue;
            objCliente.Documento = txtDocumento.Text;
            objCliente.Nombre = txtNombre.Text;
            objCliente.Apellido = txtApellido.Text;
            objCliente.Telefono = txtTelefono.Text;
            objCliente.Correo = txtCorreo.Text;
            objCliente.Departamento = txtDepartamento.Text;
            objCliente.Municipio = txtMuni.Text;
            objCliente.Direccion = txtDireccion.Text;
            objCliente.Clave = txtClave.Text;

           
            int result = Servicio.mtdEditarCliente(objCliente);

            if (result > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Perfil; Tu Perfil fue actualizado exitosamente');", true);
                Response.Redirect("Perfil.aspx");
            }

        }
       
    }
}