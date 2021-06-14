<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminStatistics.aspx.cs" Inherits="Proje.Web.AdminStatistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="info">
				<div class="circle">
					
						<br />Aktif<br /> 
							  Firma Sayısı
						<h3>
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h3>
					
				</div>
				<div class="circle">
				
							<br />Toplam <br />
									Sipariş
							
						<h3>
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h3>
					
				</div>
				<div class="circle">
					
						<br />Teslim<br />Edilen Sipariş
						<h3>
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></h3>
					
				</div>
				<div class="circle">
					
						<br />Ürün<br /> Sayısı
						<h3>
                            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></h3>
					
				</div>
	</div>
</asp:Content>
