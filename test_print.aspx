<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test_print.aspx.cs" Inherits="test_print" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">

        .auto-style77 {
            font-size: x-large;
            text-align: justify;
        }
        .auto-style4 {
            border-style: none;
            width: 945px;
            height: 278px;
        }
        .auto-style9 {
            width: 250px;
            height: 69px;
            text-align: justify;
        }
        .auto-style22 {
            color: #FF0000;
        }
        .auto-style10 {
            width: 500px;
            height: 69px;
            text-align: justify;
        }
        .auto-style12 {
            height: 69px;
            width: 133px;
            text-align: justify;
        }
        .auto-style63 {
            width: 250px;
            text-align: justify;
            height: 70px;
        }
        .auto-style64 {
            width: 500px;
            text-align: justify;
            height: 70px;
        }
        .auto-style65 {
            width: 133px;
            text-align: justify;
            height: 70px;
        }
        .auto-style81 {
            width: 1125px;
        }
        .auto-style82 {
            width: 530px;
        }
        .auto-style83 {
            width: 50px;
        }
        </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>
        <p class="auto-style77">
            Basic Details:</p>
        <table class="auto-style4">
            <tr>
                <td class="auto-style9"><strong>Address in Delhi:<span class="auto-style22">&nbsp; </span></td>
                <td class="auto-style10">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style12">Pincode:&nbsp; </td>
                <td class="auto-style9">
            <strong>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Telephone:&nbsp; </td>
                <td class="auto-style10">
            <strong>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </strong>
                </td>
                <td class="auto-style12">Mobile No:&nbsp;<br />
                </td>
                <td class="auto-style9">
            <strong>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style63">Permanent Address:</td>
                <td class="auto-style64">
            <strong>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </strong>
                </td>
                <td class="auto-style65">Pincode:</td>
                <td class="auto-style63">
                    <br />
            <strong>
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style63">Telephone:</td>
                <td class="auto-style64">
            <strong>
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
            </strong>
                </td>
                <td class="auto-style65">Mobile No:</td>
                <td class="auto-style63">
            <strong>
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </strong>
                </td>
            </tr>
        </table>
        <table class="auto-style81">
            <tr>
                <td class="auto-style82">
            <strong>Father&#39;s/Guardian&#39;s/Husband&#39;s Occupation </strong>
		        </td>
                <td>
            <strong>
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style82">
            <strong>Mother&#39;s Occupation </strong>
		        </td>
                <td>
            <strong>
                    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
            </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style82">
            <strong>Are you pursuing any other course in this or any other University/Instituition?</strong></td>
                <td class="auto-style83">
            <strong>
                    <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
            </strong>
		            </td>
            </tr>
            <tr>
                <td class="auto-style82">
            <strong>Delhi University&#39;s Enrollment Number (if any)</strong></td>
                <td>
            <strong>
                    <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
            </strong>
                </td>
            </tr>
        </table>
            </strong>
    
    </div>
        <asp:Button ID="print_button" runat="server" OnClick="print_button_Click" Text="print" />
    </form>
</body>
</html>
