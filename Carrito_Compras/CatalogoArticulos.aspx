<%@ Page Title="Catalogo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CatalogoArticulos.aspx.cs" Inherits="Carrito_Compras.CatalogoArticulos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1 style="color: black; font-style: italic; margin-left: auto; margin-right: auto; text-align: center;">Catálogo de artículos</h1>
        <div>

            <div>
                <%foreach (var articulo in listaArticulos)
                        { %>
                    <a href="Detalle.aspx?idArticulo="<%=articulo.Id.ToString()%>"></a>
                    
                       <% } %>
            </div>
            <div>
                <asp:Button BorderStyle="Inset" ID="btnBuscar" runat="server" Text="Buscar por nombre:" OnClick="btnBuscar_Click" />
            </div>
            <div>
                <asp:TextBox MaxLength="200" ID="txtBuscar" runat="server" TextMode="Search" CausesValidation="true"></asp:TextBox>
            </div>        
                
            <p>
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>
        </div>
    </div>
    <hr />
    <div class="container">
        <div class="row">
            <%foreach (Dominio.Articulo item in listaArticulos)
                { %>
            <div class="col mb-1">
                <div class="card border-dark align-content-sm-center" style="width: 16rem;">
                    <img src="<% = item.ImagenUrl %>" class="card-img-top" alt="Imagen no disponible">
                    <div class="card-body">
                        <h5 style="color: darkblue; font-style: oblique" class="card-title"><% = item.Nombre %></h5>
                        <p style="color: black; font-style: italic" class="card-text"><%= item.Marca %></p>
                        <p style="color: black; font-style: italic" class="card-text">$<%= item.Precio %></p>
                        <a href="Detalle.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-info">Detalle</a>
                        <a href="Carrito.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-primary">Añadir al carrito</a>
                    </div>
                </div>
            </div>
            <% } %>
        </div>
    </div>

</asp:Content>
