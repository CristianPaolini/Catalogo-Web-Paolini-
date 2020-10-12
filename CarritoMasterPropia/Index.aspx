<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CarritoMasterPropia.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row row-cols-1 row-cols-md-4">

        <%foreach (Dominio.Articulo item in listaArticulos)
            { %>
        <div class="col mb-1">
            <div class="card border-dark mb-3" style="width: 16rem;">
                <img src="<%= item.ImagenUrl %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><% = item.Nombre %></h5>
                    <p class="card-text"><%= item.Precio %></p>
                    
                        <a href="#" class="btn btn-outline-primary">Agregar al carrito</a>
                        <a href="detalle.aspx" class="btn btn-outline-primary">Detalle</a>
                </div>
            </div>
        </div>
        <% } %>
    </div>
</asp:Content>
