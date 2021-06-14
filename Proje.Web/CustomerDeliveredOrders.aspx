<%@ Page Title="" Language="C#" MasterPageFile="~/CustomerNavBar.Master" AutoEventWireup="true" CodeBehind="CustomerDeliveredOrders.aspx.cs" Inherits="Proje.Web.CustomerDeliveredOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
        <tr>
            <th style="text-align:center"><asp:HyperLink NavigateUrl="~/CustomerPendingOrders.aspx" ID="HyperLink1" runat="server">Bekleyen Siparişler</asp:HyperLink></th>
            <th style="text-align:center"><asp:HyperLink NavigateUrl="~/CustomerDeliveredOrders.aspx" ID="HyperLink2" runat="server">Teslim Edilen Siparişler</asp:HyperLink></th>
        </tr>
    </table>
    <br />
     <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ADI</th>
            <th>ADET</th>
            <th>SATICI ADI</th>
            <th>SATICI TELEFON NUMARASI</th>
            <th>SATICI ADRESİ</th>
            <th>SİPARİŞ TARİHİ</th>
            <th>SİPARİŞ TUTARI</th>
            

        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ProductName") %></td>
                    <td><%#Eval("Count") %></td>
                    <td><%#Eval("CompanyName") %></td>
                    <td><%#Eval("Phone") %></td>
                    <td><%#Eval("Address") %></td>
                    <td><%#Eval("CreateDate") %></td>
                    <td><%#Eval("SalePrice") %></td>
                   

                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
