<%@ Page Title="Detalle" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Carrito_Compras.Detalle" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="jumbotron">
        <img src ="<% = articuloDetalle.ImagenUrl %>" class="card-img-top" alt="Imagen no disponible"; />
        <h1 class="display-4"><% = articuloDetalle.Nombre %></h1>
        <p class="lead"><% = articuloDetalle.Precio %></p>
        <hr class="my-4">
        <p><% = articuloDetalle.Descripcion %></p>
        </div>
    </div>

</asp:Content>
