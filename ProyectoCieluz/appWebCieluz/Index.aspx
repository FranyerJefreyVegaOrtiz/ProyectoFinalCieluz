<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="appWebCieluz.Formulario_web25" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!--================Home Banner Area =================-->
    <section class="home_banner_area">
        <div class="overlay"></div>
        <div class="banner_inner d-flex align-items-center">
            <div class="container">
                <div class="banner_content row">
                    <div class="offset-lg-2 col-lg-8">
                        <h3>Comodidad
                            <br />
                            Para Tus Pies
                        </h3>
                        <a class="white_bg_btn" href="Productos.aspx">Ver Colección</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================End Home Banner Area =================-->
   
    <!--================Blog Categorie Area =================-->
    <section class="blog_categorie_area">
        <div class="container">
            <div class="row">
                <div class="col-lg-4">
                    <div class="categories_post">
                        <img src="img/blog/cat-post/cat-post-3.jpg" alt="post">
                        <div class="categories_details">
                            <div class="categories_text">
                                <a href="GuiaTallas.aspx">
                                    <h5>Guia de Tallas</h5>
                                </a>
                                <div class="border_line"></div>
                                <p>Conoce tu medida exacta</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4">
                    <div class="categories_post">
                        <img src="img/blog/cat-post/cat-post-2.jpg" alt="post">
                        <div class="categories_details">
                            <div class="categories_text">
                                <a href="contact.html">
                                    <h5>Contáctanos</h5>
                                </a>
                                <div class="border_line"></div>
                                <p>Inquietudes o reclamos?</p>
                                <p>No dudes en llamarnos</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4">
                    <div class="categories_post">
                        <img src="img/blog/cat-post/cat-post-1.jpg" alt="post">
                        <div class="categories_details">
                            <div class="categories_text">
                                <a href="TerminosCondiciones.aspx">
                                    <h5>Terminos y condiciones</h5>
                                </a>
                                <div class="border_line"></div>
                                <p>Conoce las politicas de la empresa</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================Blog Categorie Area =================-->
    <div class="whole-wrap">
        <div class="container">
            <div class="section-top-border">
				<div class="row gallery-item">
					<div class="col-md-4">
						<a href="img/elements/g1.jpg" class="img-gal">
							<div class="single-gallery-image" style="background: url(img/elements/g1.jpg);"></div>
						</a>
					</div>
					<div class="col-md-4">
						<a href="img/elements/g2.jpg" class="img-gal">
							<div class="single-gallery-image" style="background: url(img/elements/g2.jpg);"></div>
						</a>
					</div>
					<div class="col-md-4">
						<a href="img/elements/g3.jpg" class="img-gal">
							<div class="single-gallery-image" style="background: url(img/elements/g3.jpg);"></div>
						</a>
					</div>
					<div class="col-md-6">
						<a href="img/elements/g4.jpg" class="img-gal">
							<div class="single-gallery-image" style="background: url(img/elements/g4.jpg);"></div>
						</a>
					</div>
					<div class="col-md-6">
						<a href="img/elements/g5.jpg" class="img-gal">
							<div class="single-gallery-image" style="background: url(img/elements/g5.jpg);"></div>
						</a>
					</div>
					<div class="col-md-4">
						<a href="img/elements/g6.jpg" class="img-gal">
							<div class="single-gallery-image" style="background: url(img/elements/g6.jpg);"></div>
						</a>
					</div>
					<div class="col-md-4">
						<a href="img/elements/g7.jpg" class="img-gal">
							<div class="single-gallery-image" style="background: url(img/elements/g7.jpg);"></div>
						</a>
					</div>
					<div class="col-md-4">
						<a href="img/elements/g8.jpg" class="img-gal">
							<div class="single-gallery-image" style="background: url(img/elements/g8.jpg);"></div>
						</a>
					</div>
				</div>
			</div>
            <div class="section-top-border">
				<h3 class="mb-30 title_color">Block Quotes</h3>
				<div class="row">
					<div class="col-lg-12">
						<blockquote class="generic-blockquote">
							“Recently, the US Federal government banned online casinos from operating in America by making it illegal to transfer money
							to them through any US bank or payment system. As a result of this law, most of the popular online casino networks
							such as Party Gaming and PlayTech left the United States. Overnight, online casino players found themselves being
							chased by the Federal government. But, after a fortnight, the online casino industry came up with a solution and new
							online casinos started taking root. These began to operate under a different business umbrella, and by doing that,
							rendered the transfer of money to and from them legal. A major part of this was enlisting electronic banking systems
							that would accept this new clarification and start doing business with me. Listed in this article are the electronic
							banking”
						</blockquote>
					</div>
				</div>
			</div>
        </div>
    </div>

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
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/popper.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/stellar.js"></script>
    <script src="vendors/lightbox/simpleLightbox.min.js"></script>
    <script src="vendors/nice-select/js/jquery.nice-select.min.js"></script>
    <script src="vendors/isotope/imagesloaded.pkgd.min.js"></script>
    <script src="vendors/isotope/isotope-min.js"></script>
    <script src="vendors/owl-carousel/owl.carousel.min.js"></script>
    <script src="js/jquery.ajaxchimp.min.js"></script>
    <script src="vendors/counter-up/jquery.waypoints.min.js"></script>
    <script src="vendors/flipclock/timer.js"></script>
    <script src="vendors/counter-up/jquery.counterup.js"></script>
    <script src="js/mail-script.js"></script>
    <script src="js/theme.js"></script>


</asp:Content>
