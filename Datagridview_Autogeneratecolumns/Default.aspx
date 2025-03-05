<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Datagridview_Autogeneratecolumns.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col">
            <asp:GridView runat="server" ID="dgvAutos" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Color" DataField="Color" />
                    <asp:BoundField HeaderText="Usado" DataField="Usado" />
                    <asp:BoundField HeaderText="Importado" DataField="Importado" />
                </Columns>
            </asp:GridView>
            <a href="AutoForm.aspx">Agregar</a>
        </div>


    </div>

</asp:Content>
