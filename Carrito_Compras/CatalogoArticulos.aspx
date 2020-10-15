<%@ Page Title="Catalogo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CatalogoArticulos.aspx.cs" Inherits="Carrito_Compras.CatalogoArticulos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<%-- <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous" />--%>

   
   <h1 style="color:cadetblue; font-style:italic";>Catálogo de artículos</h1>
        <div>
            <asp:TextBox ID="txtBuscar"   runat="server" TextMode="Search"
                CausesValidation="true"></asp:TextBox>
            <asp:Button ID="btnBuscar" CssClass="btn btn-default" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        </div>
    
    <hr />
    <div class="container">
        <div class="row">
            <%foreach (Dominio.Articulo item in listaArticulos)
                { %>
            <div class="card-columns" style="display:inline-flex;">
                <div class="card">
                  <img src="<% = item.ImagenUrl %>" class="card-img-top" style="max-width:300px; max-height:inherit;" alt="Imagen no disponible";>
                    <div class="card-body">
                       <h5 style="color:darkblue; font-style:oblique" class="card-title"><% = item.Nombre %></h5>
                         <p style="color:black; font-style:italic" class="card-text"><%= item.Marca %></p>
                           <p style="color:black; font-style:italic" class="card-text">$<%= item.Precio %></p>
                        <a href="Detalle.aspx?idArticulo=<%=item.Id.ToString()%>"class="btn btn-primary">Detalle</a>
                        <a href="Carrito.aspx?idArticulo=<%=item.Id.ToString()%>"class="btn btn-primary">Añadir al carrito</a>
                    </div>
                </div>
            </div>
            <% } %>
        </div>
    </div>

</asp:Content>

<%--<a href="Detalle Producto.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-primary">Detalle Producto</a>--%>