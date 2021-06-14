﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Proje.Web.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Toptan Market</title>
    <style>
        HTML CSSResult Skip Results Iframe
*
{
    margin:0;
    padding: 0;
    font-family: Arial, Helvetica, sans-serif;
}

body
{
    background: #262626 url(https://images.vectorhq.com/images/previews/dae/blue-square-abstract-background-vector-illustration-art-535644.jpg);
    background-size: cover;
    display:flex;
    align-items: center;
    justify-content: center;
    min-height: 100vh;
}

form{
    background: #262626;
    padding: 20px;
    display:inline-flex;
    flex-direction: column;
    align-items: center;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0,0,0,.8);
    width:300px;
    height:400px;
}

form h2{
    margin-top:20px;
    font-size: 55px;
    color:white;
    margin-bottom: 30px;
}

form input {
    border:none;
    background: none;
    text-align: center;
    outline: none;
    padding: 10px;
    margin:20px;
    color:white;
    height:30px;
    width:70%;
    border-radius: 40px;
    transition: 0.2s ease-in;
}

form input[type="text"], form input[type="password"]{
    border:solid 2px #1B9CFC
}

form input[type="submit"]{
    border:solid 2px #55E6C1;
    box-sizing: border-box;
    height:50px;
    width:40%;
    cursor: pointer;
}


form input[type="text"]:focus, form input[type="password"]:focus{
    width:80%;
    border:solid 2px #55E6C1;
}

form input[type="submit"]:hover{
    background: #55E6C1;
    color:#182C61;
}


    </style>
</head>
<body>
    <form target="_blank" method="post" runat="server">
        <h2>Giriş</h2>
        <asp:TextBox ID="TxtMail" runat="server" placeholder="E-Posta Adresi"></asp:TextBox>
        <asp:TextBox ID="TxtPassword" runat="server" placeholder="Parola" TextMode="Password"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Giriş Yap" OnClick="Button1_Click" />
    </form>
</body>
</html>
