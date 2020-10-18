<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Carrito_Compras.Carrito" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblCarrito" runat="server" Text=""></asp:Label>
    <div class="container">
        <div class="row">
            <div class="col">
                <table class="table">
                    <tr>
                        <td>Nombre: </td>
                        <td>Marca: </td>
                        <td>Precio: </td>
                        <td>Acción: </td>
                    </tr>

                    <%foreach (var articulo in listaCarrito)
                        {
                    %>

                    <tr>
                        <td><% = articulo.Nombre %></td>
                        <td><% = articulo.Marca %></td>
                        <td>$<% = articulo.Precio %></td>
                        <td><a href="Calcs.aspx?idQuitar=<%=articulo.Id.ToString()%>" class="btn btn-danger">Eliminar</a></td>




                    </tr>

                    <% } %>
                    <tr>
                        <td>Total a pagar: $<asp:Label ID="lblTotal" runat="server" /></td>
                    </tr>

                    <tr>
                        <td>Cantidad de artículos:
                            <asp:Label ID="lblCantidad" runat="server" /></td>
                    </tr>
                </table>

            </div>

        </div>
    </div>
</asp:Content>

