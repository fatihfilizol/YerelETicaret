<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminUpdateCompany.aspx.cs" Inherits="Proje.Web.AdminUpdateCompany" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
    <div style="text-align: center">
            Firma Adı 
        <asp:TextBox ID="TxtCompanyName" runat="server" placeholder="Firma İsmi Girin" CssClass="form-control"></asp:TextBox><br />
        </div>
    <div style="text-align: center">
            Adres 
        <asp:TextBox ID="TxtAddress" runat="server" placeholder="Adres Girin" CssClass="form-control"></asp:TextBox><br />
        </div>
    <div style="text-align: center">
             Telefon Numarası
        <asp:TextBox ID="TxtPhone" runat="server" placeholder="Telefon Numarası Girin" CssClass="form-control"></asp:TextBox><br />
        </div>
    <div style="text-align: center">
            E-Posta 
        <asp:TextBox ID="TxtMail" runat="server" placeholder="E-Posta Adresini Girin" CssClass="form-control"></asp:TextBox><br />
        </div>
    <div style="text-align: center">
            Şifre Oluşturun
        <asp:TextBox ID="TxtPassword" runat="server" placeholder="Şifre Oluşturun" CssClass="form-control" TextMode="Password"></asp:TextBox><br />
        </div>
    <div style="text-align: center">
            1. Fiyat Politikası 
        <asp:TextBox ID="TxtPricePolicy1" runat="server" placeholder="örn: 0,10" CssClass="form-control"></asp:TextBox><br />
        </div>
    <div style="text-align: center">
            2. Fiyat Politikası 
        <asp:TextBox ID="TxtPricePolicy2" runat="server" placeholder="örn: 0,10" CssClass="form-control"></asp:TextBox><br />
        </div>
    <div style="text-align: center">
            3. Fiyat Politikası
        <asp:TextBox ID="TxtPricePolicy3" runat="server" placeholder="örn: 0,10" CssClass="form-control"></asp:TextBox><br />
        </div>
    <div style="text-align: center">
            Ünvan 
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList><br />
        </div>
        <div style="text-align:center">
            <asp:Button ID="Button1" runat="server" Text="Firma Güncelle" CssClass="btn btn-info" OnClick="Button1_Click" />
        </div>
        </form>
</asp:Content>
