﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="appWebCieluz.Formulario_web2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <head>
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    </head>
     <!--================Home Banner Area =================-->
    <section class="banner_area">
        <div class="banner_inner d-flex align-items-center" style="left: 3px; top: -141px">
            <div class="container">
                <div class="banner_content text-center">
                    <h2>Categoria de Compra</h2>
                    <div class="page_link">
                        <a href="index.html">Inicio</a>
                        <a href="category.html">Categoria</a>
                        <a href="Productos.aspx">Diseño Mujer</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================End Home Banner Area =================-->
    <%--<!--================Category Product Area =================-->--%>

    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <%--<asp:Image ID="Image1" Width="200" runat="server" />--%>
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <ItemTemplate>
                        <div class="col-md-4">
                             <%--<asp:Image ID="Image1" Width="200" runat="server" />--%>
                            <%--<asp:Image ID="Image1" runat="server" ImageUrl="<%# DataBinder.Eval(Container.DataItem,"imgSalida")%>" />--%>
                           <img class="img-fluid" width="200" height="200"  src="data:image/jpg;base64,<%# Eval("Foto")%>"/>
                            <br />
                             <%#DataBinder.Eval(Container.DataItem,"Nombre")%>
                            <br />
                            <a>$</a><%#DataBinder.Eval(Container.DataItem,"Precio")%><br />
                            <br />
                            <p><a href='DetalleProductos.aspx?IdProducto=<%# Eval("IdProducto") %>'>Ver Detalles</a></p>
                            <br />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>

    

    <!--================End Category Product Area =================-->
    <!--================ start footer Area  =================-->
    <footer class="footer-area section_gap">
        <div class="container">
            <div class="row">
                <div class="col-lg-3  col-md-6 col-sm-6">
                    <div class="single-footer-widget">
                        <h6 class="footer_title">Información</h6>
                        <a class="main_btn" href="GuiaTallas.aspx">Guía de Tallas</a>
                    </div>
                    <br />
                    <div class="single-footer-widget">
                        <a class="main_btn" href="TerminosCondiciones.aspx">Terminos y Condiciones</a>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 col-sm-6">
                    <div class="single-footer-widget">
                        <h6 class="footer_title">Servicio al Cliente</h6>
                        <a class="main_btn" href="contact.html">Contáctanos</a>
                    </div>
                </div>

                <div class="col-lg-3 col-md-6 col-sm-6">
                    <div class="single-footer-widget f_social_wd">
                        <h6 class="footer_title">Redes</h6>
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
                        <script>document.write(new Date().getFullYear());</script> Todos los derechos reservados  <i class="fa fa-heart-o" aria-hidden="true"></i><a href="https://colorlib.com" target="_blank"></a>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    </p>
                </div>
            </div>
        </div>
    </footer>
    
    <!--================ End footer Area  =================-->
</asp:Content>
