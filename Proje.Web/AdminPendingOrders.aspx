<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminPendingOrders.aspx.cs" Inherits="Proje.Web.AdminPendingOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
        <tr>
            <th style="text-align:center"><asp:HyperLink NavigateUrl="~/AdminPendingOrders.aspx" ID="HyperLink1" runat="server">Bekleyen Siparişler</asp:HyperLink></th>
            <th style="text-align:center"><asp:HyperLink NavigateUrl="~/AdminDeliveredOrders.aspx" ID="HyperLink2" runat="server">Teslim Edilen Siparişler</asp:HyperLink></th>
        </tr>
    </table>
    <br />
     <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ADI</th>
            <th>ADET</th>
            <th>MÜŞTERİ ADI</th>
            <th>MÜŞTERİ TELEFON NUMARASI</th>
            <th>MÜŞTERİ ADRESİ</th>
            <th>SİPARİŞ TARİHİ</th>
            <th>SİPARİŞ TUTARI</th>
            <th>SATICI FİRMA</th>

        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ProductName") %></td>
                    <td><%#Eval("Count") %></td>
                    <td><%#Eval("CustomerId") %></td>
                    <td><%#Eval("Phone") %></td>
                    <td><%#Eval("Address") %></td>
                    <td><%#Eval("CreateDate") %></td>
                    <td><%#Eval("SalePrice") %></td>
                    <td><%#Eval("CompanyId") %></td>
                   

                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
