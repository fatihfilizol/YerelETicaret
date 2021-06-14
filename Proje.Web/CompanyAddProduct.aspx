<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyAddProduct.aspx.cs" Inherits="Proje.Web.CompanyAddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <span>
            <asp:TextBox ID="TxtName" runat="server" placeholder="Ürün Adı Giriniz..." CssClass="form-control"></asp:TextBox>
        </span>
        <br />
         <span>
             <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </span>
        <br />
         <span>
            <asp:TextBox ID="TxtStock" runat="server" placeholder="Ürün Stoğu Giriniz..." CssClass="form-control"></asp:TextBox>
        </span>
        <br />
         <span>
            <asp:TextBox ID="TxtPrice" runat="server" placeholder="Ürün Fiyatı Giriniz..." CssClass="form-control"></asp:TextBox>
        </span>
        <br />
         <span>
            <asp:TextBox ID="TxtCode" runat="server" placeholder="Ürün Kodunu Giriniz..." CssClass="form-control"></asp:TextBox>
        </span>
        <br />
        <span>
            <asp:Button ID="BtnUpdateProduct" runat="server" Text="Ürün Ekle" CssClass="btn btn-primary" OnClick="BtnUpdateProduct_Click" />
        </span>
    
</asp:Content>
