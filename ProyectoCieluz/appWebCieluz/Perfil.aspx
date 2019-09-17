<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="appWebCieluz.Formulario_web22" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form class="row login_form" id="form" runat="server">
            <div class="container">
                <div class="row">
                    <div class="col-lg-6">
                        <div class="login_box_img">
                            <img class="img-fluid" src="img/login.jpg" alt="">
                            <img class="img-fluid" src="img/login.jpg" alt="">
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="login_form_inner reg_form">
                            <h1>Editar Datos</h1>
                            <asp:Label ID="lblid" runat="server" Visible="false" Text="Label"></asp:Label>
                            <div class="col-md-12 form-group">
                                <asp:Label ID="Label1" runat="server" Text="Tipo de Documento"></asp:Label>
                                <p>

                                </p>
                                <asp:DropDownList class="form-control" ID="cmbTipo" runat="server">
                                    <asp:ListItem>Cedula de Ciudadania</asp:ListItem>
                                    <asp:ListItem>Tarjeta de Identidad</asp:ListItem>
                                    <asp:ListItem>Cedula Extranjera</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:Label ID="Label2" runat="server" Text="Documento"></asp:Label>
                                <br />
                                <asp:TextBox type="number" class="form-control" ID="txtDocumento" TextMode="Number" runat="server" ></asp:TextBox>
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
                                <br />
                                <asp:TextBox class="form-control" ID="txtNombre" Text="" runat="server"></asp:TextBox>
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
                                <asp:TextBox class="form-control" ID="txtMuni" Text="" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:Label ID="Label9" runat="server" Text="Direccion"></asp:Label>
                                <br />
                                <asp:TextBox class="form-control" ID="txtDireccion" Text="" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:Label ID="Label10" runat="server" Text="Clave"></asp:Label>
                                <br />
                                <asp:TextBox class="form-control" ID="txtClave" Text="" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:Button class="btn submit_btn" type="submit" value="submit" ID="btnActualizar" runat="server" Text="Actualizar Perfil" OnClick="btnActualizar_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </form>
        <!--================ start footer Area  =================-->
    <footer class="footer-area section_gap">
        <div class="container">
            <div class="row">
                <div class="col-lg-3  col-md-6 col-sm-6">

                    <div class="single-footer-widget">
                        <h6 class="footer_title">Información</h6>
                        <br />
                        <a class="genric-btn info-border radius" href="GuiaTallas.aspx">Guía de Tallas</a>
                    </div>
                    <br />
                    <div class="single-footer-widget">
                        <a class="genric-btn info-border radius" href="TerminosCondiciones.aspx">Terminos y Condiciones</a>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 col-sm-6">
                    <div class="single-footer-widget">
                        <h6 class="footer_title">Servicio al Cliente</h6>
                        <br />
                        <a class="genric-btn info-border radius" href="contact.html">Contáctanos</a>
                    </div>
                </div>

                <div class="col-lg-3 col-md-6 col-sm-6">
                    <div class="single-footer-widget f_social_wd">
                        <h6 class="footer_title">Redes</h6>
                        <br />
                        <div class="f_social">
                            <a href="#">
                                <img src="img/facebook.png" />
                            </a>
                            <a href="#">
                                <img src="img/instagram.png" />
                            </a>

                            <a href="#">
                                <img src="img/pinterest.png" />
                            </a>
                            <a href="#">
                                <img src="img/twitter.png" />
                            </a>

                        </div>
                    </div>
                </div>
                <div class="row footer-bottom d-flex justify-content-between align-items-center">
                    <p class="col-lg-12 footer-text text-center">
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        Copyright &copy;
                        <script>document.write(new Date().getFullYear());</script>
                        Todos los derechos reservados  <i class="fa fa-heart-o" aria-hidden="true"></i><a href="https://colorlib.com" target="_blank"></a>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    </p>
                </div>
            </div>
        </div>
    </footer>

    <!--================ End footer Area  =================-->
</asp:Content>
