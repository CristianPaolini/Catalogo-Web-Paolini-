<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Carrito_Compras._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2 style="color: darkslateblue; font-style: italic">Bienvenido al carrito de compras virtual. Por favor, presione el botón que se encuentra debajo para ser redirigido/a al catálogo de artículos:</h2>
        <p class="lead"></p>
        <p><a href="CatalogoArticulos.aspx" class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">Ir al catálogo</a></p>
    </div>
    <img style="resize: both" src="https://img.freepik.com/vector-gratis/venta-carrito-compras-completo-pictograma-rojo_1284-8505.jpg?size=338&ext=jpg" alt="Imagen no disponible" />

</asp:Content>
