<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="emergencylocalcommu._Default" %>
<form id="form1" runat="server">
<asp:Label ID="Label1" runat="server" Text="COUNTRY"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 160px" 
    Width="141px"></asp:TextBox>
<p>
    <asp:Button ID="Button1" runat="server" Text="Display" 
        onclick="Button1_Click" />
</p>
<asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
</form>

