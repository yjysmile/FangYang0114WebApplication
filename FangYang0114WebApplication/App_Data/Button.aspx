<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Button.aspx.cs" Inherits="FangYang0114WebApplication.Button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonEx" runat="server" CommandName="ButtonEx" OnClick="ButtonEx_Click" OnCommand="ButtonEx_Command" Text="Normal Button" />
        </div>
        <p>
            <asp:LinkButton ID="LinkButtonEx" runat="server" CommandName="LinkButtonEx" OnClick="LinkButtonEx_Click" OnCommand="LinkButtonEx_Command">Link Button</asp:LinkButton>
        </p>
        <p>
            <asp:ImageButton ID="ImageButtonEx" runat="server" CommandName="ImageButtonEx" Height="119px" ImageUrl="~/App_Data/O]``O4TLP)`9FL_QD[94LKD.png" OnClick="ButtonEx_Click" OnCommand="ButtonEx_Command" Width="138px" />
        </p>
        <p>
            <asp:Label ID="LabMessage" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="LabClick" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
