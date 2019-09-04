<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Formulario web1.aspx.cs" Inherits="appWebCieluz.Formulario_web15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
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
							<input type="email" name="EMAIL" placeholder="Email address" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Email address'"
							 required="">
							<!-- <div style="position: absolute; left: -5000px;">
								<input type="text" name="b_36c4fd991d266f23781ded980_aefe40901a" tabindex="-1" value="">
							</div> -->
							<button type="submit" class="newsl-btn">Get Started</button>
							<div class="info"></div>
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

     <!--================Product Description Area =================-->
    <section class="product_description_area">
        <div class="container">
            <ul class="nav nav-tabs" id="myTab" role="tablist">
                <li class="nav-item">
                    <a class="nav-link" id="home-tab" data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">Description</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">Specification</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" id="contact-tab" data-toggle="tab" href="#contact" role="tab" aria-controls="contact" aria-selected="false">Comments</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" id="review-tab" data-toggle="tab" href="#review" role="tab" aria-controls="review" aria-selected="false">Reviews</a>
                </li>
            </ul>
            <div class="tab-content" id="myTabContent">
                <div class="tab-pane fade" id="home" role="tabpanel" aria-labelledby="home-tab">
                    <p>
                        Beryl Cook is one of Britain’s most talented and amusing artists .Beryl’s pictures feature women of all shapes and sizes
                        enjoying themselves .Born between the two world wars, Beryl Cook eventually left Kendrick School in Reading at the
                        age of 15, where she went to secretarial school and then into an insurance office. After moving to London and then
                        Hampton, she eventually married her next door neighbour from Reading, John Cook. He was an officer in the Merchant
                        Navy and after he left the sea in 1956, they bought a pub for a year before John took a job in Southern Rhodesia with
                        a motor company. Beryl bought their young son a box of watercolours, and when showing him how to use it, she decided
                        that she herself quite enjoyed painting. John subsequently bought her a child’s painting set for her birthday and it
                        was with this that she produced her first significant work, a half-length portrait of a dark-skinned lady with a vacant
                        expression and large drooping breasts. It was aptly named ‘Hangover’ by Beryl’s husband and
                    </p>
                    <p>
                        It is often frustrating to attempt to plan meals that are designed for one. Despite this fact, we are seeing more and
                        more recipe books and Internet websites that are dedicated to the act of cooking for one. Divorce and the death of
                        spouses or grown children leaving for college are all reasons that someone accustomed to cooking for more than one
                        would suddenly need to learn how to adjust all the cooking practices utilized before into a streamlined plan of cooking
                        that is more efficient for one person creating less
                    </p>
                </div>
                <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
                    <div class="table-responsive">
                        <table class="table">
                            <tbody>
                                <tr>
                                    <td>
                                        <h5>Width</h5>
                                    </td>
                                    <td>
                                        <h5>128mm</h5>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <h5>Height</h5>
                                    </td>
                                    <td>
                                        <h5>508mm</h5>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <h5>Depth</h5>
                                    </td>
                                    <td>
                                        <h5>85mm</h5>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <h5>Weight</h5>
                                    </td>
                                    <td>
                                        <h5>52gm</h5>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <h5>Quality checking</h5>
                                    </td>
                                    <td>
                                        <h5>yes</h5>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <h5>Freshness Duration</h5>
                                    </td>
                                    <td>
                                        <h5>03days</h5>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <h5>When packeting</h5>
                                    </td>
                                    <td>
                                        <h5>Without touch of hand</h5>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <h5>Each Box contains</h5>
                                    </td>
                                    <td>
                                        <h5>60pcs</h5>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class="tab-pane fade" id="contact" role="tabpanel" aria-labelledby="contact-tab">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="comment_list">
                                <div class="review_item">
                                    <div class="media">
                                        <div class="d-flex">
                                            <img src="img/product/single-product/review-1.png" alt="">
                                        </div>
                                        <div class="media-body">
                                            <h4>Blake Ruiz</h4>
                                            <h5>12th Feb, 2017 at 05:56 pm</h5>
                                            <a class="reply_btn" href="#">Reply</a>
                                        </div>
                                    </div>
                                    <p>
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna
                                        aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                                    </p>
                                </div>
                                <div class="review_item reply">
                                    <div class="media">
                                        <div class="d-flex">
                                            <img src="img/product/single-product/review-2.png" alt="">
                                        </div>
                                        <div class="media-body">
                                            <h4>Blake Ruiz</h4>
                                            <h5>12th Feb, 2017 at 05:56 pm</h5>
                                            <a class="reply_btn" href="#">Reply</a>
                                        </div>
                                    </div>
                                    <p>
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna
                                        aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                                    </p>
                                </div>
                                <div class="review_item">
                                    <div class="media">
                                        <div class="d-flex">
                                            <img src="img/product/single-product/review-3.png" alt="">
                                        </div>
                                        <div class="media-body">
                                            <h4>Blake Ruiz</h4>
                                            <h5>12th Feb, 2017 at 05:56 pm</h5>
                                            <a class="reply_btn" href="#">Reply</a>
                                        </div>
                                    </div>
                                    <p>
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna
                                        aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="review_box">
                                <h4>Post a comment</h4>
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="name" name="name" placeholder="Your Full name">
                                        </div>
                                    </div>
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input type="email" class="form-control" id="email" name="email" placeholder="Email Address">
                                        </div>
                                    </div>
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="number" name="number" placeholder="Phone Number">
                                        </div>
                                    </div>
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <textarea class="form-control" name="message" id="message" rows="1" placeholder="Message"></textarea>
                                        </div>
                                    </div>
                                    <div class="col-md-12 text-right">
                                        <button type="submit" value="submit" class="btn submit_btn">Submit Now</button>
                                    </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="tab-pane fade show active" id="review" role="tabpanel" aria-labelledby="review-tab">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="row total_rate">
                                <div class="col-6">
                                    <div class="box_total">
                                        <h5>Overall</h5>
                                        <h4>4.0</h4>
                                        <h6>(03 Reviews)</h6>
                                    </div>
                                </div>
                                <div class="col-6">
                                    <div class="rating_list">
                                        <h3>Based on 3 Reviews</h3>
                                        <ul class="list">
                                            <li>
                                                <a href="#">
                                                    5 Star
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i> 01
                                                </a>
                                            </li>
                                            <li>
                                                <a href="#">
                                                    4 Star
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i> 01
                                                </a>
                                            </li>
                                            <li>
                                                <a href="#">
                                                    3 Star
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i> 01
                                                </a>
                                            </li>
                                            <li>
                                                <a href="#">
                                                    2 Star
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i> 01
                                                </a>
                                            </li>
                                            <li>
                                                <a href="#">
                                                    1 Star
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i>
                                                    <i class="fa fa-star"></i> 01
                                                </a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="review_list">
                                <div class="review_item">
                                    <div class="media">
                                        <div class="d-flex">
                                            <img src="img/product/single-product/review-1.png" alt="">
                                        </div>
                                        <div class="media-body">
                                            <h4>Blake Ruiz</h4>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                        </div>
                                    </div>
                                    <p>
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna
                                        aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                                    </p>
                                </div>
                                <div class="review_item">
                                    <div class="media">
                                        <div class="d-flex">
                                            <img src="img/product/single-product/review-2.png" alt="">
                                        </div>
                                        <div class="media-body">
                                            <h4>Blake Ruiz</h4>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                        </div>
                                    </div>
                                    <p>
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna
                                        aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                                    </p>
                                </div>
                                <div class="review_item">
                                    <div class="media">
                                        <div class="d-flex">
                                            <img src="img/product/single-product/review-3.png" alt="">
                                        </div>
                                        <div class="media-body">
                                            <h4>Blake Ruiz</h4>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                        </div>
                                    </div>
                                    <p>
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna
                                        aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="review_box">
                                <h4>Add a Review</h4>
                                <p>Your Rating:</p>
                                <ul class="list">
                                    <li>
                                        <a href="#">
                                            <i class="fa fa-star"></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <i class="fa fa-star"></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <i class="fa fa-star"></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <i class="fa fa-star"></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <i class="fa fa-star"></i>
                                        </a>
                                    </li>
                                </ul>
                                <p>Outstanding</p>
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="name" name="name" placeholder="Your Full name">
                                        </div>
                                    </div>
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input type="email" class="form-control" id="email" name="email" placeholder="Email Address">
                                        </div>
                                    </div>
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="number" name="number" placeholder="Phone Number">
                                        </div>
                                    </div>
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <textarea class="form-control" name="message" id="message" rows="1" placeholder="Review"></textarea>
                                        </div>
                                    </div>
                                    <div class="col-md-12 text-right">
                                        <button type="submit" value="submit" class="btn submit_btn">Submit Now</button>
                                    </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div style="height: 153px">
            <asp:GridView ID="dgvProdu" runat="server">
            </asp:GridView>
        </div>
    </section>
    <!--================End Product Description Area =================--> 

        <!--================Feature Product Area =================-->
    <section class="feature_product_area section_gap">
        <div class="main_box">
            <div class="container-fluid">
                <div class="row">
                    <div class="main_title">
                        <h2>Featured Products</h2>
                        <p>Who are in extremely love with eco friendly system.</p>
                    </div>
                </div>
                <div class="row">
                    <div class="col col1">
                        <div class="f_p_item">
                            <div class="f_p_img">
                                <img class="img-fluid" src="img/product/feature-product/f-p-1.jpg" alt="">
                                <div class="p_icon">
                                    <a href="#">
                                        <i class="lnr lnr-heart"></i>
                                    </a>
                                    <a href="#">
                                        <i class="lnr lnr-cart"></i>
                                    </a>
                                </div>
                            </div>
                            <a href="#">
                                <h4>Long Sleeve TShirt</h4>
                            </a>
                            <h5>$150.00</h5>
                        </div>
                    </div>
                    <div class="col col2">
                        <div class="f_p_item">
                            <div class="f_p_img">
                                <img class="img-fluid" src="img/product/feature-product/f-p-2.jpg" alt="">
                                <div class="p_icon">
                                    <a href="#">
                                        <i class="lnr lnr-heart"></i>
                                    </a>
                                    <a href="#">
                                        <i class="lnr lnr-cart"></i>
                                    </a>
                                </div>
                            </div>
                            <a href="#">
                                <h4>Long Sleeve TShirt</h4>
                            </a>
                            <h5>$150.00</h5>
                        </div>
                    </div>
                    <div class="col col3">
                        <div class="f_p_item">
                            <div class="f_p_img">
                                <img class="img-fluid" src="img/product/feature-product/f-p-3.jpg" alt="">
                                <div class="p_icon">
                                    <a href="#">
                                        <i class="lnr lnr-heart"></i>
                                    </a>
                                    <a href="#">
                                        <i class="lnr lnr-cart"></i>
                                    </a>
                                </div>
                            </div>
                            <a href="#">
                                <h4>Long Sleeve TShirt</h4>
                            </a>
                            <h5>$150.00</h5>
                        </div>
                    </div>
                    <div class="col col4">
                        <div class="f_p_item">
                            <div class="f_p_img">
                                <img class="img-fluid" src="img/product/feature-product/f-p-4.jpg" alt="">
                                <div class="p_icon">
                                    <a href="#">
                                        <i class="lnr lnr-heart"></i>
                                    </a>
                                    <a href="#">
                                        <i class="lnr lnr-cart"></i>
                                    </a>
                                </div>
                            </div>
                            <a href="#">
                                <h4>Long Sleeve TShirt</h4>
                            </a>
                            <h5>$150.00</h5>
                        </div>
                    </div>
                    <div class="col col5">
                        <div class="f_p_item">
                            <div class="f_p_img">
                                <img class="img-fluid" src="img/product/feature-product/f-p-5.jpg" alt="">
                                <div class="p_icon">
                                    <a href="#">
                                        <i class="lnr lnr-heart"></i>
                                    </a>
                                    <a href="#">
                                        <i class="lnr lnr-cart"></i>
                                    </a>
                                </div>
                            </div>
                            <a href="#">
                                <h4>Long Sleeve TShirt</h4>
                            </a>
                            <h5>$150.00</h5>
                        </div>
                    </div>

                    <div class="col col6">
                        <div class="f_p_item">
                            <div class="f_p_img">
                                <img class="img-fluid" src="img/product/feature-product/f-p-5.jpg" alt="">
                                <div class="p_icon">
                                    <a href="#">
                                        <i class="lnr lnr-heart"></i>
                                    </a>
                                    <a href="#">
                                        <i class="lnr lnr-cart"></i>
                                    </a>
                                </div>
                            </div>
                            <a href="#">
                                <h4>Long Sleeve TShirt</h4>
                            </a>
                            <h5>$150.00</h5>
                        </div>
                    </div>

                    <div class="col col7">
                        <div class="f_p_item">
                            <div class="f_p_img">
                                <img class="img-fluid" src="img/product/feature-product/f-p-4.jpg" alt="">
                                <div class="p_icon">
                                    <a href="#">
                                        <i class="lnr lnr-heart"></i>
                                    </a>
                                    <a href="#">
                                        <i class="lnr lnr-cart"></i>
                                    </a>
                                </div>
                            </div>
                            <a href="#">
                                <h4>Long Sleeve TShirt</h4>
                            </a>
                            <h5>$150.00</h5>
                        </div>
                    </div>

                    <div class="col col8">
                        <div class="f_p_item">
                            <div class="f_p_img">
                                <img class="img-fluid" src="img/product/feature-product/f-p-5.jpg" alt="">
                                <div class="p_icon">
                                    <a href="#">
                                        <i class="lnr lnr-heart"></i>
                                    </a>
                                    <a href="#">
                                        <i class="lnr lnr-cart"></i>
                                    </a>
                                </div>
                            </div>
                            <a href="#">
                                <h4>Long Sleeve TShirt</h4>
                            </a>
                            <h5>$150.00</h5>
                        </div>
                    </div>
                    <div class="col col9">
                        <div class="f_p_item">
                            <div class="f_p_img">
                                <img class="img-fluid" src="img/product/feature-product/f-p-1.jpg" alt="">
                                <div class="p_icon">
                                    <a href="#">
                                        <i class="lnr lnr-heart"></i>
                                    </a>
                                    <a href="#">
                                        <i class="lnr lnr-cart"></i>
                                    </a>
                                </div>
                            </div>
                            <a href="#">
                                <h4>Long Sleeve TShirt</h4>
                            </a>
                            <h5>$150.00</h5>
                        </div>
                    </div>
                    <div class="col col10">
                        <div class="f_p_item">
                            <div class="f_p_img">
                                <img class="img-fluid" src="img/product/feature-product/f-p-4.jpg" alt="">
                                <div class="p_icon">
                                    <a href="#">
                                        <i class="lnr lnr-heart"></i>
                                    </a>
                                    <a href="#">
                                        <i class="lnr lnr-cart"></i>
                                    </a>
                                </div>
                            </div>
                            <a href="#">
                                <h4>Long Sleeve TShirt</h4>
                            </a>
                            <h5>$150.00</h5>
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
        </div>
    </section>
    <!--================End Feature Product Area =================-->
    </form>

</asp:Content>
