<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Carro.aspx.cs" Inherits="appWebCieluz.Formulario_web24" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <!--================Home Banner Area =================-->
    <%--<section class="banner_area" style="height: 252px; left: -3px; top: 1px">
        <div class="banner_inner d-flex align-items-center" style="left: 3px; top: 1px">
            <div class="container">
                <div class="banner_content text-center">
                    <h2>Categoria de Compra</h2>
                    <div class="page_link">
                        <a href="index.html">Inicio</a>
                        <a href="Carro.aspx">Carrito</a>
                    </div>
                </div>
            </div>
        </div>
    </section>--%>
    <!--================End Home Banner Area =================-->

    <link href="bootstrap-4.3.1-dist/css/style.css" rel="stylesheet" type="text/css"/>
    <link href="bootstrap-4.3.1-dist/css/bootstrap.min.css" rel="stylesheet"/>

    <form id="form1" runat="server">
        <section class="cart_area">
            <div class="container">
                <div class="cart_inner">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class="col-md-4">
                                <img class="img-fluid" width="200" height="200" src="data:image/jpg;base64,<%# Container.GetRouteUrl("FotoPro")%>" />
                                <br />
                                <%#Container.GetRouteUrl("NombrePro")%>
                                <br />
                                <a>$</a><%#Container.GetRouteUrl("PrecioPro")%><br /><br /></div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <div class="table-responsive">
                        <table class="table">
                            <thead>
                                <tr>
                                    <th scope="col">Producto</th>
                                    <th scope="col">Precio</th>
                                    <th scope="col">Talla</th>
                                    <th scope="col">Tipo de Pago</th>
                                    <th scope="col">Cantidad</th>
                                    <th scope="col">Total</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        <div class="media">
                                            <div class="d-flex">
                                                <asp:Image ID="imgFoto" Width="200" runat="server"></asp:Image>
                                            </div>
                                            <div class="media-body">
                                                <asp:Label ID="Nombre" runat="server" Text="Label"></asp:Label>
                                            </div>
                                        </div>
                                    </td>
                                    <td>
                                        <h5>
                                            <asp:TextBox class="form-control" ID="Precio" runat="server" Visible="true"></asp:TextBox></h5>
                                    </td>
                                    <td>
                                        <h5>
                                            <asp:TextBox class="form-control" ID="txtTalla" runat="server" Visible="true"></asp:TextBox></h5>
                                    </td>
                                    <td>

                                        <h5>
                                            <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                                <asp:ListItem>Efectivo</asp:ListItem>
                                                <asp:ListItem>Tarjeta de Credito</asp:ListItem>
                                            </asp:DropDownList></h5>
                                    </td>

                                    <td>
                                        <div class="product_count">
                                            <asp:TextBox ID="txtCantidad" runat="server">1</asp:TextBox>
                                            <button onclick="var result = document.getElementById('sst'); var sst = result.value; if( !isNaN( sst )) result.value++;return false;"
                                                class="increase items-count" type="button">
                                                <i class="lnr lnr-chevron-up"></i>
                                            </button>
                                            <button onclick="var result = document.getElementById('sst'); var sst = result.value; if( !isNaN( sst ) &amp;&amp; sst > 0 ) result.value--;return false;"
                                                class="reduced items-count" type="button">
                                                <i class="lnr lnr-chevron-down"></i>
                                            </button>
                                        </div>
                                    </td>
                                    <td>
                                        <h5>
                                            <a>$</a><asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
                                        </h5>
                                        <br />
                                        <asp:Button Class="main_btn" ID="btnOperacion" runat="server" Text="Calcular" OnClick="btnOperacion_Click" />
                                    </td>
                                </tr>
                                <asp:TextBox ID="txtRecive" runat="server" Visible="false"></asp:TextBox>
                                <tr class="out_button_area">
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td>
                                        <div class="checkout_btn_inner">
                                            <a class="gray_btn" href="Productos.aspx">Seguir Comprando</a>
                                            <asp:Button class="main_btn" ID="btnCompra" runat="server" Text="Proceder con la compra" OnClick="btnCompra_Click" />
                                        </div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </section>
        <asp:TextBox ID="txtFrom" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtClave" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtSubject" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtBody" runat="server" Visible="false"></asp:TextBox>
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
