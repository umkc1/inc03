<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

<h1>Profiles Page</h1>

<div style="float:right; margin-top: -23px;">
<asp:Label ID="lblusername" runat="server" Font-Bold="true"></asp:Label><br />
<asp:LinkButton ID="lnklogout" runat="server" Text="Logout" Font-Bold="True" 
        onclick="lnklogout_Click"></asp:LinkButton>
</div>

<div style="margin-top:20px">
<table>



<tr>
<td>
Name : 
</td>
<td>
<asp:Label ID="lblname" runat="server"></asp:Label>
</td>
</tr>

<tr>
<td>
Age : 
</td>
<td>
<asp:Label ID="lblage" runat="server"></asp:Label>
</td>
</tr>

<tr>
<td>
Phone Number : 
</td>
<td>
<asp:Label ID="lblphone" runat="server"></asp:Label>
</td>
</tr>

</table>
</div>

</asp:Content>

