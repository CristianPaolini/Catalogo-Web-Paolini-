<%@ Page Title="Error" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Carrito_Compras.Error" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1 style="color: red">Error</h1>
        <asp:Label Font-Underline="true" Font-Size="Larger" Text="Se ha producido un error en la solicitud recibida" ID="lblError" runat="server" />
        <div>
            <p><a href="CatalogoArticulos.aspx" class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">Ir al catálogo</a></p>
        </div>
    </div>

</asp:Content>
