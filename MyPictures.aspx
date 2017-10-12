<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myPictures.aspx.cs" Inherits="_myPictures" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 159px">
    <form id="form1" runat="server">
    <div>
    
        Select one of my pictures </div>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Height="31px" Width="135px" AutoPostBack="True">
            <asp:ListItem>Select a picture</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
            <asp:ListItem>e</asp:ListItem>
            <asp:ListItem>f</asp:ListItem>
        </asp:DropDownList>
<br />

        <asp:Image ID="Image1" runat="server" Height="392px" ImageAlign="Right" Visible="False" Width="561px" />
        <br />
        <br />

        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Add a border to the picture" Visible="False" />
        <br />

        <br />
<asp:Label ID="Label1" runat="server" Text="Select border color :" Visible="False"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Visible="False">
            <asp:ListItem>brown</asp:ListItem>
            <asp:ListItem>blue</asp:ListItem>
            <asp:ListItem>aqua</asp:ListItem>
            <asp:ListItem>red</asp:ListItem>
            <asp:ListItem>green</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Select size of the border :" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Visible="False">
            <asp:ListItem Value="a1">1 pixel</asp:ListItem>
            <asp:ListItem Value="a2">2 pixels</asp:ListItem>
            <asp:ListItem Value="a3">3 pixels</asp:ListItem>
            <asp:ListItem Value="a4">4 pixels</asp:ListItem>
            <asp:ListItem Value="a5">5 pixels</asp:ListItem>
        </asp:DropDownList>
        <br />

        <p>

            <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
