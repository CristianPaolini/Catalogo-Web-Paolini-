<%@ Page Title="Detalle" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Carrito_Compras.Detalle" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card border-dark align-content-sm-center" style="width: 18rem;">
        <img src="<% = articuloDetalle.ImagenUrl %>" class="card-img-top" alt="Imagen no disponible">
        <div class="card-body">
            <h2 style="color: black; font-style: italic" class="display-4"><%=articuloDetalle.Nombre %></h2>
            <p style="color: black; font-style: italic" class="lead">Precio: $<% = articuloDetalle.Precio %></p>
            <p style="color: black; font-style: italic" class="lead">Marca: <% = articuloDetalle.Marca %></p>
            <p style="color: black; font-style: italic" class="lead">Categoría: <% = articuloDetalle.Categoria %></p>
            <p><a href="CatalogoArticulos.aspx" class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">Volver al catálogo &raquo;</a></p>
        </div>
    </div>
</asp:Content>
