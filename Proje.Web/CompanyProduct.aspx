<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyProduct.aspx.cs" Inherits="Proje.Web.CompanyProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ID</th>
            <th>ÜRÜN ADI</th>
            <th>KATEGORİ</th>
            <th>STOK</th>
            <th>FİYAT</th>
            <th>ÜRÜN KODU</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("ProductName") %></td>
                    <td><%#Eval("CategoryName") %></td>
                    <td><%#Eval("Stock") %></td>
                    <td><%#Eval("Price") %></td>
                    <td><%#Eval("Code") %></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/CompanyDeleteProduct.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/CompanyUpdateProduct.aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-info">Güncelle</asp:HyperLink></td>

                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="CompanyAddProduct.aspx" class="btn btn-info">Ürün Ekle</a>
</asp:Content>
