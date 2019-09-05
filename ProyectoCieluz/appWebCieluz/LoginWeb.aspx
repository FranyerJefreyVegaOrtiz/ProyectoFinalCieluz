<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="LoginWeb.aspx.cs" Inherits="appWebCieluz.Formulario_web25" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:textbox Id="txtCorreo" runat="server"></asp:textbox>
    <br />
    <asp:textbox Id="txtClave" runat="server"></asp:textbox>
    <br />
    <asp:button Id="btnIngresar" runat="server" text="Ingresar" OnClick="btnIngresar_Click" />
</asp:Content>
