<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

<h1>Login page</h1>

<div style="margin-top:15px">
<table>

<tr>
<td>
UserName
</td>
<td>
<asp:TextBox ID="txtuname" runat="server" CssClass="txt"></asp:TextBox>
</td>
</tr>

<tr>
<td>
Password
</td>
<td>
<asp:TextBox ID="txtpassword" runat="server" TextMode="Password" CssClass="txt"></asp:TextBox>
</td>
</tr>

<tr>
<td>
</td>
<td>
<asp:Button ID="btnsubmit" runat="server" text="Login" CssClass="button" 
        style=" height: 34px;
    width: 160px;" onclick="btnsubmit_Click" />
</td>
</tr>
</table>
</div>


</asp:Content>

