﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="DetalleProductos.aspx.cs" Inherits="appWebCieluz.Formulario_web23" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <asp:TextBox ID="txtRecive"  runat="server"></asp:TextBox>
                <asp:Image ID="ImgProducto" Width="200" runat="server" />
                <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblColor" runat="server" Text=""></asp:Label>
                <asp:Label ID="LblPrecio" runat="server" Text="$"></asp:Label>
                <asp:Label ID="lblDescripcion" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblDiseño" runat="server" Text=""></asp:Label>
             </div>
        </div>
    </form>
</body>
</asp:Content>
