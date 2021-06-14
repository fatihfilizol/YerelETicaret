<%@ Page Title="" Language="C#" MasterPageFile="~/CustomerNavBar.Master" AutoEventWireup="true" CodeBehind="CustomerAddOrder.aspx.cs" Inherits="Proje.Web.CustomerAddOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form runat="server">
        <div style="text-align:center"><asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList></div>
        <table class="table table-bordered">
            <tr>
                <th>ÜRÜN KODU</th>
                <th>ÜRÜN ADI</th>
                <th>KATEGORİ</th>
                <th>ÜRÜN FİYATI</th>
                <th>SEPETE EKLE</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval ("Code") %></td>
                    <td><%#Eval ("ProductName") %></td>
                    <td><%#Eval ("CategoryName") %></td>
                    <td><%#Eval ("Price") %></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/CustomerAddCart.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-info">Sepete Ekle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </table>
        <table class="table table-bordered align-top">
                        <tr>
                            <th>Ürün</th>
                            <th>Miktar</th>
                            <th>Fiyat</th>
                            <th>Sepetten Sil</th>
                        </tr>
                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval ("ProductName") %></td>
                                <td><%#Eval ("Count") %></td>
                                <td><%#Eval ("Price") %></td>
                                <td><asp:HyperLink NavigateUrl='<%#"~/CustomerRemoveProductInCart.aspx?Id=" + Eval("Id") %>' ID="HyperLink3" runat="server" CssClass="btn-danger">Sil</asp:HyperLink></td>

                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
        </table>
        <asp:Button ID="Button1" runat="server" Text="Siparişi Tamamla" OnClick="Button1_Click" />

    </form>
</asp:Content>
