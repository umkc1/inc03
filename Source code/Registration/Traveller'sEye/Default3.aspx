<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link href="Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
     <div class="page">
     
          
  



<div style="margin-top:20px">

<div style="float:right; margin-top: 20px;">
<asp:Label ID="lblusername" runat="server" Font-Bold="true"></asp:Label><br />
<asp:LinkButton ID="lnklogout" runat="server" Text="Logout" Font-Bold="True" 
        onclick="lnklogout_Click"></asp:LinkButton>
</div>

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
    
        <div class="clear">
        </div>
    </div>


    </form>
</body>
</html>
