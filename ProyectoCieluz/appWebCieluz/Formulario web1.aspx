<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Formulario web1.aspx.cs" Inherits="appWebCieluz.Formulario_web15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!--================Hot Deals Area =================-->
	<section class="hot_deals_area section_gap">
		<div class="container-fluid">
			<div class="row">
				<div class="col-lg-6">
					<div class="hot_deal_box">
						<img class="img-fluid" src="img/product/hot_deals/deal1.jpg" alt="">
						<div class="content">
							<h2>Hot Deals of this Month</h2>
							<p>shop now</p>
						</div>
						<a class="hot_deal_link" href="#"></a>
					</div>
				</div>

				<div class="col-lg-6">
					<div class="hot_deal_box">
						<img class="img-fluid" src="img/product/hot_deals/deal1.jpg" alt="">
						<div class="content">
							<h2>Hot Deals of this Month</h2>
							<p>shop now</p>
						</div>
						<a class="hot_deal_link" href="#"></a>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!--================End Hot Deals Area =================-->

    <!--================ Subscription Area ================-->
	<section class="subscription-area section_gap">
		<div class="container">
			<div class="row justify-content-center">
				<div class="col-lg-8">
					<div class="section-title text-center">
						<h2>Subscribe for Our Newsletter</h2>
						<span>We won’t send any kind of spam</span>
					</div>
				</div>
			</div>
			<div class="row justify-content-center">
				<div class="col-lg-6">
					<div id="mc_embed_signup">
						<form target="_blank" novalidate action="https://spondonit.us12.list-manage.com/subscribe/post?u=1462626880ade1ac87bd9c93a&id=92a4423d01"
						 method="get" class="subscription relative">
							<input type="email" name="EMAIL" placeholder="Email address" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Email address'"
							 required="">
							<!-- <div style="position: absolute; left: -5000px;">
								<input type="text" name="b_36c4fd991d266f23781ded980_aefe40901a" tabindex="-1" value="">
							</div> -->
							<button type="submit" class="newsl-btn">Get Started</button>
							<div class="info"></div>
						</form>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!--================ End Subscription Area ================-->

	<!--================Clients Logo Area =================-->
	<section class="clients_logo_area">
		<div class="container-fluid">
			<div class="clients_slider owl-carousel">
				<div class="item">
					<img src="img/clients-logo/c-logo-1.png" alt="">
				</div>
				<div class="item">
					<img src="img/clients-logo/c-logo-2.png" alt="">
				</div>
				<div class="item">
					<img src="img/clients-logo/c-logo-3.png" alt="">
				</div>
				<div class="item">
					<img src="img/clients-logo/c-logo-4.png" alt="">
				</div>
				<div class="item">
					<img src="img/clients-logo/c-logo-5.png" alt="">
				</div>
			</div>
		</div>
	</section>
	<!--================End Clients Logo Area =================-->

    <!--=========Cantidad de productos para mostrar=========-->
                        <div class="left_dorp">
                            <select class="sorting">
                                <option value="1">Default sorting</option>
                                <option value="2">Default sorting 01</option>
                                <option value="4">Default sorting 02</option>
                            </select>
                            <select class="show">
                                <option value="1">Show 12</option>
                                <option value="2">Show 14</option>
                                <option value="4">Show 16</option>
                            </select>
                        </div>
     <!--========End Cantidad de productos para mostrar===========-->

    <!--================Filtrar=====================-->
    <aside class="left_widgets cat_widgets">
                            <div class="l_w_title">
                                <h3>Browse Categories</h3>
                            </div>
                            <div class="widgets_inner">
                                <ul class="list">
                                    <li>
                                        <a href="#">Fruits and Vegetables</a>
                                    </li>
                                    <li>
                                        <a href="#">Meat and Fish</a>
                                        <ul class="list">
                                            <li>
                                                <a href="#">Frozen Fish</a>
                                            </li>
                                            <li>
                                                <a href="#">Dried Fish</a>
                                            </li>
                                            <li>
                                                <a href="#">Fresh Fish</a>
                                            </li>
                                            <li>
                                                <a href="#">Meat Alternatives</a>
                                            </li>
                                            <li>
                                                <a href="#">Meat</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="#">Cooking</a>
                                        <ul class="list">
                                            <li>
                                                <a href="#">Frozen Fish</a>
                                            </li>
                                            <li>
                                                <a href="#">Dried Fish</a>
                                            </li>
                                            <li>
                                                <a href="#">Fresh Fish</a>
                                            </li>
                                            <li>
                                                <a href="#">Meat Alternatives</a>
                                            </li>
                                            <li>
                                                <a href="#">Meat</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="#">Beverages</a>
                                        <ul class="list">
                                            <li>
                                                <a href="#">Frozen Fish</a>
                                            </li>
                                            <li>
                                                <a href="#">Dried Fish</a>
                                            </li>
                                            <li>
                                                <a href="#">Fresh Fish</a>
                                            </li>
                                            <li>
                                                <a href="#">Meat Alternatives</a>
                                            </li>
                                            <li>
                                                <a href="#">Meat</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="#">Home and Cleaning</a>
                                    </li>
                                </ul>
                            </div>
                        </aside>

    <div class="widgets_inner">
                                <h4>Price</h4>
                                <div class="range_item">
                                    <div id="slider-range"></div>
                                    <div class="row m0">
                                        <label for="amount">Price : </label>
                                        <input type="text" id="amount" readonly>
                                    </div>
                                </div>
                            </div>
     <!--================End Filtrar=====================-->


</asp:Content>
