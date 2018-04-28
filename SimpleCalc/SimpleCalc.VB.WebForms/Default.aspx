<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="SimpleCalc.VB.WebForms._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SimpleCalc - VB - WebForms</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>

      <asp:TextBox ID="Number1TextBox" runat="server" Text="10" Style="text-align: right; width: 100px; height: 29px; font-size: 24px; margin: 2px;">10</asp:TextBox>
      <asp:DropDownList ID="OperatorComboBox" runat="server" Style="text-align: right; width: 100px; height: 29px; font-size: 24px; margin: 2px;">
        <asp:ListItem>+</asp:ListItem>
        <asp:ListItem>-</asp:ListItem>
        <asp:ListItem>*</asp:ListItem>
        <asp:ListItem>/</asp:ListItem>
      </asp:DropDownList>
      <asp:TextBox ID="Number2TextBox" runat="server" Text="10" Style="text-align: right; width: 100px; height: 29px; font-size: 24px; margin: 2px;" />
      <asp:Button ID="CalculateButton" runat="server" Text="=" Style="text-align: right; width: 100px; height: 29px; font-size: 24px; margin: 2px;" OnClick="CalculateButton_Click" />
      <asp:TextBox ID="AnswerTextBox" runat="server" Text="0" Style="text-align: right; width: 100px; height: 29px; font-size: 24px; margin: 2px;" />

    </div>
  </form>
</body>
</html>
