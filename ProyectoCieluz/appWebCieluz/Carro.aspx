<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Carro.aspx.cs" Inherits="appWebCieluz.Formulario_web24" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4">
                             <%--<asp:Image ID="Image1" Width="200" runat="server" />--%>
                            <%--<asp:Image ID="Image1" runat="server" ImageUrl="<%# DataBinder.Eval(Container.DataItem,"imgSalida")%>" />--%>
                           <img class="img-fluid" width="200" height="200"  src="data:image/jpg;base64,<%# Container.GetRouteUrl("FotoPro")%>"/>
                            <br />
                             <%#Container.GetRouteUrl("NombrePro")%>
                            <br />
                            <a>$</a><%#Container.GetRouteUrl("PrecioPro")%><br /><br /></div>
                    </ItemTemplate>
                    </asp:Repeater>
                
                    <asp:Image ID="imgFoto" Width="200" runat="server"></asp:Image>
                <br />
                        <asp:Label ID="Nombre" runat="server" Text="Label"></asp:Label>
                <br />
                        <asp:Label ID="Precio" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:TextBox ID="txtRecive"  runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label1" runat="server" Text="CANTIDAD:"></asp:Label>
                <asp:TextBox class="form-control" ID="txtCantidad" runat="server" ></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="TALLA:"></asp:Label>
                <asp:TextBox class="form-control" ID="txtTalla" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="PRECIOTOTAL"></asp:Label>
                <asp:TextBox class="form-control" ID="txtPrecioTotal" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Text="TIPOPAGO"></asp:Label>
                <asp:TextBox class="form-control" ID="txtTipoPago" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="id" runat="server" Text=""></asp:Label>
                <asp:Button class="main_btn"  ID="Button1" runat="server" Text="Registra Pedidos" OnClick="Button1_Click" />
               
             </div>
        </div>

    </form>
</asp:Content>
