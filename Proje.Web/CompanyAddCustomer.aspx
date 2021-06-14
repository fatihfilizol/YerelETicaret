<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyAddCustomer.aspx.cs" Inherits="Proje.Web.CompanyAddCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div style="text-align: center">
            Müşteri Seçin 
        <asp:DropDownList ID="DropDownCustomer" runat="server" CssClass="form-control"></asp:DropDownList><br />
        </div>
        <div style="text-align: center">
            Uygulanacak Fiyat Politikasını Seçin 
        
            <div style="text-align:center"><asp:RadioButtonList ID="RadioButtonList1" runat="server" >
                
            </asp:RadioButtonList></div>
        </div>
        <div style="text-align:center">
            <asp:Button ID="Button1" runat="server" Text="Müşteri Ekle" CssClass="btn btn-info" OnClick="Button1_Click" />
        </div>
    
</asp:Content>
