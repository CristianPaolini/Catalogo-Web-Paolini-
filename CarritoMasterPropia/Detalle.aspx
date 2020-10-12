<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="CarritoMasterPropia.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="card mb-3" style="max-width: 540px;">
        <div class="row no-gutters">
            <div class="col-md-4">
                <img src="" class="card-img" alt="...">
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h5 class="card-title">articuloDetalle.Nombre</h5>
                    <p class="card-text"></p>
                    <asp:Button class="btn btn-primary btn-lg" ID="BtnAgregar" runat="server" Text="Agregar al carrito" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
