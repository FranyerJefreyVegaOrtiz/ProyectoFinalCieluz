<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="DetalleProductos.aspx.cs" Inherits="appWebCieluz.Formulario_web23" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

        <!--================Home Banner Area =================-->
       <%--  <section class="banner_area" style="height: 252px; left: -3px; top: 1px">
        <div class="banner_inner d-flex align-items-center" style="left: 3px; top: 1px">
            <div class="container">
                <div class="banner_content text-center">
                    <h2>Detalles del Producto</h2>
                    <div class="page_link">
                        <a href="index.html">Inicio</a>
                        <a href="category.html">Categoria</a>
                        <a href="single-product.html">Detalles del Producto</a>
                    </div>
                </div>
            </div>
        </div>
    </section>--%>
    <!--================End Home Banner Area =================-->
                 <!--================Single Product Area =================-->
<div class="product_image_area">
    <section>
        <form id="form1" runat="server">
        <div class="container">
                <div class="row s_product_inner">
            <div class="row">
                <div class="col-lg-6">
                       <asp:TextBox ID="txtRecive"  runat="server" Visible="False"></asp:TextBox>
                    <div class="s_product_img">
                        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                            <div class="carousel-inner">
                                <div class="carousel-item active">
                                     <asp:Image class="d-block w-100"  ID="Image1" Width="700" runat="server" />
                                    <asp:Image class="img-fluid"  ID="ImgProducto" Width="700" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                </div>

                 <div class="col-lg-5 offset-lg-1">
                    <div class="s_product_text">
                        <h5><asp:Label ID="lblNombre" runat="server" Font-Size="XX-Large"></asp:Label></h5>
                        <h2>$<asp:Label ID="lblPrecio" runat="server" Text="$" Font-Size="Larger"></asp:Label></h2>
                        <ul class="list">
                            <li>
                                <a class="active" href="#">
                        <span>Color</span> : <asp:Label ID="lblColor" runat="server" Text="" Font-Size="Medium"></asp:Label>
                        </a>
                            </li>
                            <li>
                                <li>
                                <a href="#">
                        <span>Diseño</span> :  <asp:Label ID="lblDiseño" runat="server" Text="" Font-Size="Medium"></asp:Label>
                         </a>
                            </li>
                        </ul>
                       <p><asp:Label ID="lblDescripcion" runat="server" Text="" Font-Size="Medium"></asp:Label></p>
                        
                         <div class="card_area">
                        <a><asp:button class="main_btn"  ID="btnCarro" runat="server" text="Añadir al carrito" OnClick="btnCarro_Click" /></a>
                             </div>
                    </div>
                     </div>
                </div>
            </div>
            </div>
            </form>
    </section>
</div>
        <%--    <p><a href='Carro.aspx?IdProducto=txtRecive.Text'>Añadir al carrito</a></p>--%>
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
                        <script>document.write(new Date().getFullYear());</script> Todos los derechos reservados  <i class="fa fa-heart-o" aria-hidden="true"></i><a href="https://colorlib.com" target="_blank"></a>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    </p>
                </div>
            </div>
        </div>
    </footer>
    
    <!--================ End footer Area  =================-->
</asp:Content>
