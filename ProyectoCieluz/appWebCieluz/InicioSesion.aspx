<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="appWebCieluz.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <section class="login_box_area p_120">
        <div class="container">
            <div class="row">
                <div class="col-lg-6">
                    <div class="login_box_img">
                        <img class="img-fluid" src="img/login.jpg" alt="">
                        <div class="hover">
                            <h2>Vuelve A Intentar</h2>
                            <a class="main_btn" href="login.html">Iniciar Sesion</a>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="login_form_inner reg_form">
                        <h2>¡A ocurrido un ploblema!</h2>
                        <asp:label id="lblMensaje" runat="server" text="Label"></asp:label>bel>
                        <img class="img-fluid" src="img/error.jpg" alt="">
                    </div>
                </div>
            </div>
        </div>
    </section>
  </asp:Content>
