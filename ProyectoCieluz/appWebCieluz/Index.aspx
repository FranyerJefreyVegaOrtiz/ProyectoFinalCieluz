<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="appWebCieluz.Formulario_web25" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      
<asp:Label ID="lblCorreo" runat="server" Text="Label"></asp:Label>
    <br />
<asp:Label ID="lblIdCliente" runat="server" Text="Label"></asp:Label>

    <p>
    &nbsp;
        </p>

    <asp:loginview Id="Loginview1" runat="server"></asp:loginview>
</asp:Content>