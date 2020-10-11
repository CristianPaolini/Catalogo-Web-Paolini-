<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Carrito_Compras.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Aquí podrá encontrar medios para contactar a los desarrolladores del proyecto...</h3>
    <address>
        UTN FRGP<br />
        Gral. Pacheco, Bs. As<br />
        <abbr title="Phone">Celular</abbr>
        15-00000000
    </address>

    <address>
        <strong>Soporte:</strong>   <a href="mailto:Support@example.com">Soporte@paolinicoder.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@paolinicoder.com</a>
    </address>
</asp:Content>
