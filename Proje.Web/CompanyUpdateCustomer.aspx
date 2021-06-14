<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyUpdateCustomer.aspx.cs" Inherits="Proje.Web.CompanyUpdateCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div style="text-align: center">
            Müşteri Seçin 
        <asp:DropDownList ID="DropDownCustomer" runat="server" CssClass="form-control" Enabled="false"></asp:DropDownList><br />
        </div>
        <div style="text-align: center">
            Uygulanacak Fiyat Politikasını Seçin 
        
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="form-control">
                
            </asp:RadioButtonList>
        </div>
        <div style="text-align:center">
            <asp:Button ID="Button1" runat="server" Text="Müşteri Güncelle" CssClass="btn btn-info" OnClick="Button1_Click" />
        </div>
    
</asp:Content>
