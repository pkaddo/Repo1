<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCalc.CS.WebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SimpleCalc - CS - WebForms</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      <asp:TextBox ID="Number1TextBox" runat="server" text="10" style="text-align: right; width:100px; height:29px; font-size: 24px;  margin: 2px;">10</asp:TextBox>
      <asp:DropDownList ID="OperatorComboBox" runat="server" style="text-align: right; width:100px; height:29px; font-size: 24px;  margin: 2px;">
        <asp:ListItem>+</asp:ListItem>
        <asp:ListItem>-</asp:ListItem>
        <asp:ListItem>*</asp:ListItem>
        <asp:ListItem>/</asp:ListItem>
      </asp:DropDownList>
      <asp:TextBox ID="Number2TextBox" runat="server" text="10" style="text-align: right; width:100px; height:29px; font-size: 24px; margin: 2px;" />
      <asp:Button ID="CalculateButton" runat="server" Text="=" style="text-align: right; width:100px; height:29px; font-size: 24px;  margin: 2px;" OnClick="CalculateButton_Click" />
      <asp:TextBox ID="AnswerTextBox" runat="server" text="0" style="text-align: right; width:100px; height:29px; font-size: 24px;  margin: 2px;" />
    
    </div>
    </form>
</body>
</html>
