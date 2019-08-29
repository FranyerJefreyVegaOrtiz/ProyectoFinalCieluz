<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="appWebCieluz.Formulario_web22" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <!--================Login Box Area =================-->
    <section  class="feature_product_area section_gap">
       <div class="container">
            <div class="row">
                <%--<div class="col-lg-6">
                    <div class="login_box_img">
                        <img class="img-fluid" src="img/login.jpg" alt="">
                        <div class="hover">
                            <h4>New to our website?</h4>
                            <p>There are advances being made in science and technology everyday, and a good example of this is the</p>
                            <a class="main_btn" href="#">Create an Account</a>
                        </div>
                    </div>
                </div>--%>
                 <div class="main_box">
                      <div class="main_title">
                        <h2>Crear Nuevo Cliente</h2>
                        <form class="row login_form" action="RegistrarCliente.aspx" method="post">
                            <%--<div class="col-md-12 form-group">
                                <select type="text" class="form-control" id="" runat="server" >
                                    <option value="0"type="text" class="form-control" id="" runat="server">Cedula de ciudadania</option>
                                    <option value="1"type="text" class="form-control" id="" runat="server">Tarjeta de identidad</option>
                                    <option value="2"type="text" class="form-control" id="" runat="server">Cedula extranjera</option>
                                </select>
                            </div>--%>
                            <div class="col-md-12 form-group">
                                <input type="number" class="form-control" id="Documento" name="Documento" placeholder="Documento" runat="server" required>

                            </div>
                            <div class="col-md-12 form-group">
                                <input type="text" class="form-control" id="Nombre" name="Nombre" placeholder="Nombre" runat="server" required>
                            </div>
                            <div class="col-md-12 form-group">
                                <input type="text" class="form-control" id="Apellido" name="Apellido" placeholder="Apellido" runat="server" required>
                            </div>
                            <div class="col-md-12 form-group">
                                <input type="number" class="form-control" id="Telefono" name="Telefono" placeholder="Telefono" runat="server" required>
                            </div>
                            <div class="col-md-12 form-group">
                                <input type="email" class="form-control" id="Correo" name="Correo" placeholder="Correo" runat="server" required>
                            </div>
                            <div class="col-md-12 form-group">
                                <input type="text" class="form-control" id="Departamento" name="Departamento" placeholder="Departamento" runat="server" required>
                            </div>
                            <div class="col-md-12 form-group">
                                <input type="text" class="form-control" id="Municipio" name="Municipio" placeholder="Municipio" runat="server" required>
                            </div>
                            <div class="col-md-12 form-group">
                                <input type="text" class="form-control" id="Direccion" name="Direccion" placeholder="Direccion" runat="server" required>
                            </div>
                            <div class="col-md-12 form-group">
                                <input type="password" class="form-control" id="Clave" name="Clave" placeholder="Clave" runat="server" required>
                            </div>
                            <div class="col-md-12 form-group">
                                <div class="creat_account">
                                    <input type="checkbox" id="f-option2" name="selector">
                                    <label for="f-option2">Quieres iniciar sesion de una vez</label>
                                </div>
                            </div>
                            <div class="col-md-12 form-group">
                                <button type="submit" value="submit" class="btn submit_btn" runat="server">Registrar</button>
                            </div>
                        </form>
                    </div>
                    </div>
                </div>
            </div>
        </div>
        

    </section>
    <!--================End Login Box Area =================-->
</asp:Content>
