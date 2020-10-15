<%@ Page Title="Detalle" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Carrito_Compras.Detalle" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="card" style="width: 18rem;">
            <img src="<% = articuloDetalle.ImagenUrl %>" class="card-img-top" alt="No hay imagen disponible para el artículo">
            <div class="card-body">
                <h2 class="display-4"><%=articuloDetalle.Nombre %></h2>
                <p class="lead">$<% = articuloDetalle.Precio %></p>
                <p class="lead">Marca: <% = articuloDetalle.Marca.Descripcion %></p>
                <p class="lead">Categoría: <% = articuloDetalle.Categoria.Descripcion %></p>
                <p><a href="CatalogoArticulos.aspx" class="btn btn-primary btn-lg">Volver al catálogo &raquo;</a></p>
            </div>
        </div>
    </div>

</asp:Content>
