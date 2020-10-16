<%@ Page Title="Error" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Carrito_Compras.Error" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1 style="color: red">Error</h1>
        <asp:Label Text="text" ID="lblError" runat="server" />
        <div>
            <a href="CatalogoArticulos.aspx">Volver</a>
        </div>
    </div>

</asp:Content>
