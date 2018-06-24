<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormKlient.aspx.cs" Inherits="serwisWEBasp.FormKlient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelTemp" runat="server" Text="Temperatura: "></asp:Label>
    
        <asp:TextBox ID="TextBoxTemp" runat="server"></asp:TextBox>
    
        <br />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Z:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Celsjusz</asp:ListItem>
            <asp:ListItem>Fahrenheit</asp:ListItem>
            <asp:ListItem>Kelwin</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Na:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" style="margin-left: 0px">
            <asp:ListItem>Celsjusz</asp:ListItem>
            <asp:ListItem>Fahrenheit</asp:ListItem>
            <asp:ListItem>Kelwin</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="ButtonKonwertuj" runat="server" Text="Konwertuj" OnClick="ButtonKonwertuj_Click" />
        <br />
        <br />
        <asp:Label ID="LabelWynik" runat="server" Text="Wynik: "></asp:Label>
        <asp:Label ID="LabelRezultat" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
