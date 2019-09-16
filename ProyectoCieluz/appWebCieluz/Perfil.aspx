<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="appWebCieluz.Formulario_web22" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <form class="row login_form" id="form" runat="server">
          <div class="container">
              <div class="form-row">
                  <asp:Label ID="lblid" runat="server" Visible="false" Text="Label"></asp:Label>
                  <div class="col-md-12 form-group">
                      <asp:Label ID="Label1" runat="server" Text="Tipo de Documento"></asp:Label>
                      <br />
                      <asp:DropDownList ID="cmbTipo" runat="server">
                          <asp:ListItem>Cedula de Ciudadania</asp:ListItem>
                          <asp:ListItem>Tarjeta de Identidad</asp:ListItem>
                          <asp:ListItem>Cedula Extranjera</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                  <div class="col-md-12 form-group">
                      <asp:Label ID="Label2" runat="server" Text="Documento"></asp:Label>
                      <br />
                      <asp:TextBox class="form-control" ID="txtDocumento" TextMode="Number" runat="server"></asp:TextBox>
                  </div>
                  <div class="col-md-12 form-group">
                      <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
                      <br />
                      <asp:TextBox class="form-control" ID="txtNombre" Text="" runat="server" ></asp:TextBox>
                  </div>
                  <div class="col-md-12 form-group">
                      <asp:Label ID="Label4" runat="server" Text="Apellido"></asp:Label>
                      <br />
                      <asp:TextBox class="form-control" ID="txtApellido" Text="" runat="server"></asp:TextBox>
                  </div>
                  <div class="col-md-12 form-group">
                      <asp:Label ID="Label5" runat="server" Text="Telefono"></asp:Label>
                      <br />
                      <asp:TextBox class="form-control" ID="txtTelefono" TextMode="Number" runat="server"></asp:TextBox>
                  </div>
                  <div class="col-md-12 form-group">
                      <asp:Label ID="Label6" runat="server" Text="Correo"></asp:Label>
                      <br />
                      <asp:TextBox class="form-control" ID="txtCorreo" TextMode="Email" runat="server"></asp:TextBox>
                  </div>
                  <div class="col-md-12 form-group">
                      <asp:Label ID="Label7" runat="server" Text="Departamento"></asp:Label>
                      <br />
                      <asp:TextBox class="form-control" ID="txtDepartamento" Text="" runat="server"></asp:TextBox>
                  </div>
                  <div class="col-md-12 form-group">
                      <asp:Label ID="Label8" runat="server" Text="Municipio"></asp:Label>
                      <br />
                      <asp:TextBox class="form-control" ID="txtMuni" Text=""  runat="server"></asp:TextBox>
                  </div>
                  <div class="col-md-12 form-group">
                      <asp:Label ID="Label9" runat="server" Text="Direccion"></asp:Label>
                      <br />
                      <asp:TextBox class="form-control" ID="txtDireccion" Text="" runat="server"></asp:TextBox>
                  </div>
                  <div class="col-md-12 form-group">
                      <asp:Label ID="Label10" runat="server" Text="Clave"></asp:Label>
                      <br />
                      <asp:TextBox class="form-control" ID="txtClave" Text="" runat="server" ></asp:TextBox>
                  </div>
                   <div class="col-md-12 form-group">
                       <asp:Button class="main_btn" ID="btnActualizar" runat="server" Text="Actualizar Perfil" OnClick="btnActualizar_Click" />
                   </div>
              </div>
          </div>
      </form>
</asp:Content>
