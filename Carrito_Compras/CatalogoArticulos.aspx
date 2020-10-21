<%@ Page Title="Catalogo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CatalogoArticulos.aspx.cs" Inherits="Carrito_Compras.CatalogoArticulos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <%foreach (var articulo in listaArticulos)
            { %>
        <a href="Detalle.aspx?idArticulo=<%=articulo.Id.ToString()%>"></a>

        <% } %>
    </div>
    <div>
        <asp:Button class="btn btn-md btn-primary" BorderStyle="Inset" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />

        <asp:TextBox Width="170px" Height="35px" MaxLength="200" ID="txtBuscar" runat="server" TextMode="Search" CausesValidation="true"></asp:TextBox>
    </div>

    <hr />

    <div class="container">
        <div class="row row-cols-1 row-cols-md-4">
            <%foreach (Dominio.Articulo item in listaArticulos)
                { %>

            <div class="col mb-4">
                <div class="card border-dark align-content-sm-center" style="">
                    <img style="max-width: 300px; max-height: 300px; object-fit: contain" src="<% = item.ImagenUrl %>" class="card-img-top" alt="Imagen no disponible">
                    <div class="card-body">
                        <h5 style="color: darkblue; font-style: oblique" class="card-title"><% = item.Nombre %></h5>
                        <p style="color: black; font-style: italic" class="card-text"><%= item.Marca %></p>
                        <a href="Detalle.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-info">Detalle</a>
                        <a href="Carrito.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-primary">Añadir al carrito</a>
                    </div>
                </div>
            </div>

            <% } %>
        </div>
    </div>

</asp:Content>
