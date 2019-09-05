<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="DetalleProductos.aspx.cs" Inherits="appWebCieluz.Formulario_web23" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
                 <!--================Single Product Area =================-->
    <div class="product_image_area">
        <form id="form1" runat="server">
        <div class="container">
            <div class="row s_product_inner">
                <div class="col-lg-6">
                    <div class="s_product_img">
                        <asp:TextBox ID="txtRecive"  runat="server" Visible="False"></asp:TextBox>
                        <asp:Image ID="ImgProducto" Width="200" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-5 offset-lg-1">
                    <div class="s_product_text">
                        <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:Label ID="lblColor" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:Label ID="LblPrecio" runat="server" Text="$"></asp:Label>
                        <br />
                        <asp:Label ID="lblDescripcion" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:Label ID="lblDiseño" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:button class="main_btn"  ID="btnCarro" runat="server" text="Añadir al carrito" OnClick="btnCarro_Click" />
                     </div>
                </div>
            </div>
            </form>
        </div>
        <%--    <p><a href='Carro.aspx?IdProducto=txtRecive.Text'>Añadir al carrito</a></p>--%>
</asp:Content>
