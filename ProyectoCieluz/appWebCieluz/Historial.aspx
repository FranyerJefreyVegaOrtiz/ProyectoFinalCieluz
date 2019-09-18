<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="appWebCieluz.Formulario_web26" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <!--================Category Product Area =================-->
    <section class="cat_product_area section_gap">
        <div class="container-fluid">
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

                <div class="latest_product_inner row">
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
        </div>
    </section>
</asp:Content>
