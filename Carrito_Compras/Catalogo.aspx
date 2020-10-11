<%@ Page Title="Catalogo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="Carrito_Compras.Catalogo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<%--    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous" />--%>
    <div>
   <h1 style="margin-left: auto; margin-right: auto; text-align: center; color:cadetblue; font-style:italic";>Catálogo de artículos</h1>
    </div>
    <hr />
    <div class="container">
        <div class="row">
            <%foreach (Dominio.Articulo item in listaArticulos)
                { %>
            <div class="card-columns" style="display:inline-flex; margin: 10px">
                <div class="card">
                  <img src="<% = item.ImagenUrl %>" class="card-img-top" style="max-width:300px; max-height:300px;" alt="Imagen no disponible";>
                    <div class="card-body">
                       <h5 style="margin-left: auto; margin-right: auto; text-align: center; color:darkblue; font-style:oblique" class="card-title"><% = item.Nombre %></h5>
                         <p style="margin-left: auto; margin-right: auto; text-align: center; color:black; font-style:italic" class="card-text"><%= item.Marca %></p>
                           <p style="margin-left: auto; margin-right: auto; text-align: center; color:black; font-style:italic" class="card-text">$<%= item.Precio %></p>
                        <a href="#" class="btn btn-primary">Añadir al carrito</a>
                    </div>
                </div>
            </div>
            <% } %>
        </div>
    </div>
</asp:Content>
