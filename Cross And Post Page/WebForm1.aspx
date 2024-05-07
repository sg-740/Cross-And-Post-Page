<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cross_And_Post_Page.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Page1</h3>
            <asp:Button ID="Button1" runat="server" Text="Post Back Submition" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Cross Page Submition" PostBackUrl="~/WebForm2.aspx" OnClick="Button2_Click" />
        </div>
        <br />
        <hr />
        <div>
            <table>
                <tr>
                    <td><b>EnterUsername: </b></td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1"><b>Enter Location: </b></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Post Back" PostBackUrl="~/WebForm2.aspx" OnClick="Button3_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
