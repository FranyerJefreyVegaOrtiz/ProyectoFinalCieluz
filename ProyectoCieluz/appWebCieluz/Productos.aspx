<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="appWebCieluz.Formulario_web2" %>
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
                        <a href="Productos.aspx">Productos</a>
                    </div>
                </div>
            </div>
        </div>
    </section>--%>
    <!--================End Home Banner Area =================-->
               <form id="form1" runat="server">

    <!--================Category Product Area =================-->
    <section class="cat_product_area section_gap">
        <div class="container-fluid">
            <div class="row flex-row-reverse">
                <div class="col-lg-9">
                    <div class="product_top_bar">
                        <div class="right_page ml-auto">
                            <nav class="cat_page" aria-label="Page navigation example">
                                <ul class="pagination">
                                    <li class="page-item">
                                        <a class="page-link" href="#">
                                            <i class="fa fa-long-arrow-left" aria-hidden="true"></i>
                                        </a>
                                    </li>
                                    <li class="page-item active">
                                        <a class="page-link" href="#">1</a>
                                    </li>
                                    <li class="page-item">
                                        <a class="page-link" href="#">2</a>
                                    </li>
                                    <li class="page-item">
                                        <a class="page-link" href="#">3</a>
                                    </li>
                                    <li class="page-item blank">
                                        <a class="page-link" href="#">...</a>
                                    </li>
                                    <li class="page-item">
                                        <a class="page-link" href="#">6</a>
                                    </li>
                                    <li class="page-item">
                                        <a class="page-link" href="#">
                                            <i class="fa fa-long-arrow-right" aria-hidden="true"></i>
                                        </a>
                                    </li>
                                </ul>
                            </nav>
                        </div>
                    </div>
                   
                        <div class="latest_product_inner row" >
                            <%--<div class=" col-sm-6">--%>
                                <div class="f_p_item">
                                     <div class="row">
                                    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                        <ItemTemplate>
                                            <div class="col-md-4">
                                                <div class="f_p_img">
                                            <img class="img-fluid"  height="" alt="" src="data:image/jpg;base64,<%# Eval("Foto")%> "/>
                                            </div>
                                    <a href='DetalleProductos.aspx?IdProducto=<%# Eval("IdProducto") %>'>
                                        <h4> <%#DataBinder.Eval(Container.DataItem,"Nombre")%> </h4>
                                        </a>
                                        <a> <h5>$<%#DataBinder.Eval(Container.DataItem,"Precio")%></h5>
                                        </a>
                                                </div>
                                        </ItemTemplate>
                                        </asp:Repeater>
                                </div>
                            </div>
                        </div>
                       </div>
                <div class="col-lg-3">
                    <div class="left_sidebar_area">
                        <aside class="left_widgets p_filter_widgets">
                            <div class="l_w_title">
                                <h3>Filtrar Productos</h3>
                            </div>
                            <div class="widgets_inner">
                                <h4>Diseño</h4>
                                <ul class="list">
                                    <li>
                                        <asp:Button ID="btnTodos" class="genric-btn default-border circle" runat="server" Text="Todos" OnClick="btnTodos_Click" />
                                    </li>
                                    <li >
                                        <asp:Button ID="btnSencillas" class="genric-btn default-border circle" runat="server" text="Sencillas" OnClick="btnSencillas_Click" />
                                    </li>
                                    <li>
                                        <asp:Button ID="btnAnimales" class="genric-btn default-border circle"  runat="server" Text="Animales" OnClick="btnAnimales_Click" />
                                    </li>
                                    <li>
                                        <asp:Button ID="btnFlores" class="genric-btn default-border circle" runat="server" Text="Flores" OnClick="btnFlores_Click" />
                                    </li>
                                    <li>
                                        <asp:Button ID="btnPersonajes" class="genric-btn default-border circle" runat="server" Text="Personajes" OnClick="btnPersonajes_Click" />
                                    </li>
                                     <li>
                                        <asp:Button ID="btnEspecial" class="genric-btn default-border circle" runat="server" Text="Especial" OnClick="btnEspecial_Click" />
                                    </li>
                                </ul>
                            </div>
                            <div class="widgets_inner">
                                <h4>Color</h4>
                                <ul class="list">
                                    <li>
                                        <asp:Button ID="btnTodosColor" class="genric-btn default-border circle" runat="server" Text="Todos" OnClick="btnTodosColor_Click" />
                                    </li>
                                    <li>
                                        <asp:Button ID="btnAmarillo" class="genric-btn default-border circle" runat="server" Text="Amarillo" OnClick="btnAmarillo_Click" />
                                    </li>
                                    <li>
                                        <asp:Button ID="btnAzul" class="genric-btn default-border circle" runat="server" Text="Azul" OnClick="btnAzul_Click" />
                                    </li>
                                    <li>
                                        <asp:Button ID="btnBlanco" class="genric-btn default-border circle" runat="server" Text="Blanco" OnClick="btnBlanco_Click" />
                                    </li>
                                    <li>
                                        <asp:Button ID="btnCafé" class="genric-btn default-border circle" runat="server" Text="Café" OnClick="btnCafé_Click" />
                                    </li>
                                     <li>
                                        <asp:Button ID="btnGris" class="genric-btn default-border circle" runat="server" Text="Gris" OnClick="btnGris_Click" />
                                    </li>
                                      <li>
                                        <asp:button ID="btnMorado" class="genric-btn default-border circle" runat="server" Text="Morado" OnClick="btnMorado_Click" />
                                    </li>
                                     <li>
                                        <asp:Button ID="btnNaranja" class="genric-btn default-border circle" runat="server" Text="Naranja" OnClick="btnNaranja_Click" />
                                    </li>
                                     <li>
                                        <asp:Button ID="btnNegro" class="genric-btn default-border circle" runat="server" Text="Negro" OnClick="btnNegro_Click" />
                                    </li>
                                    <li>
                                        <asp:Button ID="btnRojo" class="genric-btn default-border circle" runat="server" Text="Rojo" OnClick="btnRojo_Click" />
                                    </li> 
                                    <li>
                                        <asp:button ID="btnRosado" class="genric-btn default-border circle" runat="server" Text="Rosado" OnClick="btnRosado_Click" />
                                    </li>
                                      <li>
                                        <asp:Button ID="btnVerde" class="genric-btn default-border circle" runat="server" Text="Verde" OnClick="btnVerde_Click" />
                                    </li>
                                </ul>
                            </div>

                        </aside>
                    </div>
                </div>
            </div>
            
            <div class="row">
                <nav class="cat_page mx-auto" aria-label="Page navigation example">
                    <ul class="pagination">
                        <li class="page-item">
                            <a class="page-link" href="#">
                                <i class="fa fa-chevron-left" aria-hidden="true"></i>
                            </a>
                        </li>
                        <li class="page-item active">
                            <a class="page-link" href="#">01</a>
                        </li>
                        <li class="page-item">
                            <a class="page-link" href="#">02</a>
                        </li>
                        <li class="page-item">
                            <a class="page-link" href="#">03</a>
                        </li>
                        <li class="page-item blank">
                            <a class="page-link" href="#">...</a>
                        </li>
                        <li class="page-item">
                            <a class="page-link" href="#">09</a>
                        </li>
                        <li class="page-item">
                            <a class="page-link" href="#">
                                <i class="fa fa-chevron-right" aria-hidden="true"></i>
                            </a>
                        </li>
                    </ul>
                </nav>
            </div>
          </div>
    </section>   
    </form>
    <!--================End Category Product Area =================-->
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
