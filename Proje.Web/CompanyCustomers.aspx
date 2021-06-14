<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyCustomers.aspx.cs" Inherits="Proje.Web.CompanyCustomers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     

        <div style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="Firmalar"></asp:Label></div>
        <br />
        <div style="text-align: center">
            Firma Ara: 
        <asp:TextBox ID="TxtCompanies" runat="server" placeholder="Firma İsmi Girin"></asp:TextBox>
            
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div><br />
        <table class="table table-bordered">
            <tr>
                <th>FİRMA ADI</th>
                <th>TELEFON</th>
                <th>E-POSTA</th>
                <th>ADRES</th>
                <th>FİYAT POLİTİKASI</th>
                <th>GÜNCELLE</th>
                <th>SİL</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("CompanyName") %></td>
                        <td><%#Eval("Phone") %></td>
                        <td><%#Eval("EMail") %></td>
                        <td><%#Eval("Address") %></td>
                        <td><%#Eval("PricePolicy") %></td>
                        <td><asp:HyperLink NavigateUrl='<%#"~/CompanyUpdateCustomer.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-info">Güncelle</asp:HyperLink></td>
                        <td><asp:HyperLink NavigateUrl='<%#"~/CompanyDeleteCustomer.aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <asp:HyperLink NavigateUrl="~/CompanyAddCustomer.aspx" ID="HyperLink1" runat="server" CssClass="btn btn-info">Firma Ekle</asp:HyperLink>
    
</asp:Content>
