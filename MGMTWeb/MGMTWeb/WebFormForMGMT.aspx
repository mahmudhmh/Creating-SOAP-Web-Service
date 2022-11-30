<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormForMGMT.aspx.cs" Inherits="MGMTWeb.WebFormForMGMT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Management of Risk And Quality Web Service</title>
    <style type="text/css">
        .auto-style1 {
            width: 76%;
            height: 501px;
        }
        .auto-style4 {
            width: 225px;
        }
        .auto-style5 {
            width: 712px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is my Web Service Application
            To Calculate Areas<br />
            <br />
        </div>
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style4">Enter Radius to calculate area of Circle</td>
                <td class="auto-style5">
                    <asp:TextBox ID="Circle" runat="server" Height="35px" Width="292px"></asp:TextBox>
                    <asp:Button ID="CircleBtn" runat="server" OnClick="CircleBtn_Click" Text="Calculate" />
                </td>
                <td>
                    <asp:Label ID="CircleArea" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Enter Length of any side to calculate area of Square</td>
                <td class="auto-style5">
                    <asp:TextBox ID="Square" runat="server" Height="35px" Width="292px"></asp:TextBox>
                    <asp:Button ID="SquareBtn" runat="server" OnClick="SquareBtn_Click" Text="Calculate" />
                </td>
                <td>
                    <asp:Label ID="SquareArea" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Enter Width and Length to calculate area of Rectangle</td>
                <td class="auto-style5">
                    <asp:TextBox ID="Width" runat="server" Height="35px" Width="280px"></asp:TextBox>
                    <asp:TextBox ID="Length" runat="server" Height="35px" Width="278px"></asp:TextBox>
                    <asp:Button ID="RectangleBtn" runat="server" OnClick="RectangleBtn_Click" Text="Calculate" />
                </td>
                <td>
                    <asp:Label ID="RectangleArea" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Enter Height and Base to calculate area of Triangle</td>
                <td class="auto-style5">
                    <asp:TextBox ID="Height" runat="server" Height="35px" Width="280px"></asp:TextBox>
                    <asp:TextBox ID="Base" runat="server" Height="35px" Width="278px"></asp:TextBox>
                    <asp:Button ID="TriangleBtn" runat="server" OnClick="TriangleBtn_Click" Text="Calculate" />
                </td>
                <td>
                    <asp:Label ID="TriangleArea" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
