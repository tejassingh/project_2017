<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adm_form.aspx.cs" Inherits="PhD.admission_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
            background-color: #FFFFFF;
        }
        .auto-style2 {
            font-size: medium;
        }
        .auto-style3 {
            font-size: x-large;
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
        .auto-style10 {
            width: 500px;
            height: 69px;
            text-align: justify;
        }
        .auto-style12 {
            height: 69px;
            width: 125px;
            text-align: justify;
        }
        .auto-style22 {
            color: #FF0000;
        }
        .auto-style24 {
            width: 1004px;
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            height: 221px;
        }
        .auto-style53 {
			font-size: large;
		}
        .auto-style54 {
            width: 100%;
        }
        .auto-style57 {
            margin-left: 3px;
        }
        .auto-style60 {
            margin-left: 0px;
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
            width: 125px;
            text-align: justify;
            height: 70px;
        }
        .auto-style67 {
            width: 244px;
            text-align: justify;
        }
        .auto-style75 {
            text-align: center;
        }
        .auto-style76 {
            width: 777px;
            text-align: justify;
        }
        .auto-style77 {
            font-size: x-large;
            text-align: justify;
        }
        .auto-style80 {
            text-align: justify;
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
        .auto-style91 {
            height: 21px;
            width: 485px;
            text-align: justify;
        }
        .auto-style94 {
            height: 21px;
            text-align: justify;
            width: 160px;
        }
        .auto-style101 {
            height: 39px;
            width: 485px;
            text-align: justify;
        }
        .auto-style103 {
            height: 39px;
            width: 160px;
            text-align: justify;
        }
        .auto-style105 {
            height: 39px;
            width: 485px;
            text-align: right;
        }
        .auto-style106 {
            height: 39px;
            width: 160px;
            text-align: left;
        }
        .auto-style109 {
            width: 350px;
            height: 40px;
            font-size: medium;
        }
        .auto-style110 {
            height: 40px;
        }
        .auto-style115 {
            width: 350px;
            height: 41px;
            font-size: medium;
        }
        .auto-style116 {
            height: 41px;
        }
        .auto-style119 {
            width: 1561px;
            height: 23px;
            text-align: justify;
        }
        .auto-style120 {
            width: 1561px;
            text-align: justify;
        }
        .auto-style128 {
            width: 1561px;
            text-align: justify;
            height: 26px;
        }
        .auto-style129 {
            width: 777px;
            height: 26px;
            text-align: left;
        }
        .auto-style130 {
            width: 190px;
            height: 23px;
            text-align: justify;
        }
        .auto-style131 {
            width: 777px;
        }
        .auto-style133 {
            width: 189px;
            height: 23px;
            text-align: justify;
        }
        .auto-style134 {
            width: 777px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style80">
            <strong><span class="auto-style2">Department :</span>
            <asp:DropDownList ID="DropDownListDepartment" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListDepartment_SelectedIndexChanged1">
                <asp:ListItem>Select Department</asp:ListItem>
                <asp:ListItem>Computer Science</asp:ListItem>
                <asp:ListItem>Mathematics</asp:ListItem>
                <asp:ListItem>Operational Research</asp:ListItem>
                <asp:ListItem>Statistics</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="auto-style1" ErrorMessage="Select Department Name." InitialValue="Select Department" ControlToValidate="DropDownListDepartment"></asp:RequiredFieldValidator>
&nbsp;</div>
        <p class="auto-style77">
            <strong>Basic Details:</strong></p>
        <table class="auto-style4">
            <tr>
                <td class="auto-style9"><strong>Address in Delhi:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox_Address_Delhi" runat="server" TextMode="MultiLine" Width="500px" OnTextChanged="TextBox_Address_Delhi_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox_Address_Delhi" ErrorMessage="It must be filled" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style12">Pincode:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox_Pincode_Delhi" runat="server"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox_Pincode_Delhi" CssClass="auto-style22" ErrorMessage="It must be numeric" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Telephone:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox_Telephone_Delhi" runat="server"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox_Telephone_Delhi" CssClass="auto-style22" ErrorMessage="It must be numeric." ValidationExpression="\+?\d[\d -]{8,12}\d"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style12">Mobile No:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox_MobileNo" runat="server"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox_MobileNo" CssClass="auto-style22" ErrorMessage="RegularExpressionValidator" ValidationExpression="\+?\d[\d -]{8,12}\d">It must be numeric</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style63">Permanent Address:</td>
                <td class="auto-style64">
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Same as Address in Delhi" Width="250px" />
                    <asp:TextBox ID="TextBox_Per_Add" runat="server" TextMode="MultiLine" Width="500px" OnTextChanged="TextBox_Per_Add_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox_Per_Add" ErrorMessage="It must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style65">Pincode:</td>
                <td class="auto-style63">
                    <asp:TextBox ID="TextBox_Per_Pincode" runat="server"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox_Per_Pincode" CssClass="auto-style22" ErrorMessage="It must be numeric" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style63">Telephone:</td>
                <td class="auto-style64">
                    <asp:TextBox ID="TextBox_Per_Telephone" runat="server"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox_Per_Telephone" CssClass="auto-style22" ErrorMessage="It must be numeric" ValidationExpression="\+?\d[\d -]{8,12}\d"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style65">Mobile No:</td>
                <td class="auto-style63">
                    <asp:TextBox ID="TextBox_Per_MobileNo" runat="server"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TextBox_Per_MobileNo" ErrorMessage="It must be numeric" ForeColor="Red" ValidationExpression="\+?\d[\d -]{8,12}\d"></asp:RegularExpressionValidator>
                    </strong>
                    </strong>
                </td>
            </tr>
        </table>
        <table class="auto-style81">
            <tr>
                <td class="auto-style82">
            <strong>Father&#39;s/Guardian&#39;s/Husband&#39;s Occupation </strong>
		        </td>
                <td colspan="2">
            <strong>
			<asp:TextBox ID="TextBox25" runat="server" Width="270px" OnTextChanged="TextBox25_TextChanged"></asp:TextBox>
			</strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style82">
            <strong>Mother&#39;s Occupation </strong>
		        </td>
                <td colspan="2"><strong><asp:TextBox ID="TextBox30" runat="server" Width="270px"></asp:TextBox>
			</strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style82">
            <strong>Are you pursuing any other course in this or any other University/Instituition?</strong></td>
                <td class="auto-style83">
            <strong>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="auto-style57" RepeatDirection="Horizontal" Width="187px" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1">
                            <asp:ListItem>YES</asp:ListItem>
                            <asp:ListItem>NO</asp:ListItem>
                        </asp:RadioButtonList>
                        </strong>
		            </td>
                <td>
            <strong>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged1" Width="308px" CssClass="auto-style60" Enabled="False">If Yes,then give details</asp:TextBox>
                        </strong>
		            </td>
            </tr>
            <tr>
                <td class="auto-style82">
            <strong>Delhi University&#39;s Enrollment Number (if any)</strong></td>
                <td colspan="2">
            <strong>
			<asp:TextBox ID="TextBox26" runat="server" Width="270px"></asp:TextBox>
			</strong>
                </td>
            </tr>
        </table>
        <p class="auto-style80">
            &nbsp;&nbsp;
        </p>
        <p class="auto-style77">
            <strong>Educational Details:</strong></p>
        <table class="auto-style24" border="0">
            <tr>
                <td class="auto-style91" style="border-style: solid; border-width: thin"><strong>Examination passed:</strong></td>
                <td class="auto-style94" style="border-style: solid; border-width: thin"><strong>University</strong></td>
                <td class="auto-style94" style="border-style: solid; border-width: thin"><strong>Year</strong></td>
                <td class="auto-style94" style="border-style: solid; border-width: thin"><strong>Div./Grade</strong></td>
                <td class="auto-style94" style="border-style: solid; border-width: thin"><strong>Subject(s)</strong></td>
            </tr>
            <tr>
                <td class="auto-style101" style="border-style: solid; border-width: thin"><strong>B.A/B.Sc./B.Com.(Hons/Pass)/B.B.A./B.Tech.</strong></td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox_Grad_Uni" runat="server" Height="39px" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox_Grad_Uni"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox_Grad_year" runat="server" Height="39px" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox_Grad_year" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox_Grad_Div" runat="server" Height="39px" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox_Grad_Div" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style106">
                    <asp:TextBox ID="TextBox8" runat="server" Height="39px" OnTextChanged="TextBox8_TextChanged" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox8" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style101" style="border-style: solid; border-width: thin"><strong>M.A./M.Sc./M.C.A./M.Com./M.B.A./M.Tech.</strong></td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox9" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox10" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox11" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox12" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style101" style="border-style: solid; border-width: thin"><strong>&nbsp; M.Phil in&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Part -I</strong></td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox13" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox14" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox15" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox16" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style105" style="border-style: solid; border-width: thin"><strong>Part-II</strong></td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox17" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox18" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox19" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox20" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style101" style="border-style: solid; border-width: thin"><strong>Any other Examination passed:</strong></td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox21" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox22" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox23" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox24" runat="server" Height="39px" Width="160px"></asp:TextBox>
            </strong>
                </td>
            </tr>
        </table>
    <p class="auto-style80">
        &nbsp;</p>
    <p class="auto-style77">
        <strong>Research Details:</strong></p>
        <table class="auto-style4">
            <tr>
                <td class="auto-style109">
            <strong>Fellowship/Scholarship under</strong></td>
                <td class="auto-style110">
            <strong>
			<asp:TextBox ID="TextBox27" runat="server" Width="270px"></asp:TextBox>
			scheme</strong></td>
            </tr>
            <tr>
                <td class="auto-style109">
            <strong><span class="auto-style2">Languages Known:</span></strong></td>
                <td class="auto-style110"><strong>
            <asp:TextBox ID="TextBox_Languages0" runat="server" CssClass="auto-style53" TextMode="MultiLine"></asp:TextBox>
                    <span class="auto-style53">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox_Languages0" ErrorMessage="It must not be empty" ForeColor="Red" CssClass="auto-style2"></asp:RequiredFieldValidator>
                    </span>
            </strong></td>
            </tr>
            <tr>
                <td class="auto-style115">
            <strong>Precise details of research experience(if any)</strong></td>
                <td class="auto-style116">
		<asp:TextBox ID="TextBox28" runat="server" TextMode="MultiLine" Width="376px"></asp:TextBox>
		        </td>
            </tr>
            <tr>
                <td class="auto-style115">
		<strong>Title of the proposed Research Topic</strong></td>
                <td class="auto-style116"><strong>
		<asp:TextBox ID="TextBox29" runat="server" TextMode="MultiLine" Width="376px"></asp:TextBox>
                    </strong>
                </td>
            </tr>
        </table>
		<div class="auto-style24">
		    <span class="auto-style3">
            <br />
            UNDERTAKING DECLARATION:<br />
		<br />
		</span>a) I have carefully gone through the rules as prescribed under Ordinance-VIB and by the Board relating to the Doctories of Philosphy (Ph.D)Course and I undertake to abide by them during the tenure of my research in the department of
            <asp:TextBox ID="TextBox37" runat="server" Enabled="False" OnTextChanged="TextBox37_TextChanged1"></asp:TextBox>
            &nbsp; 
&nbsp;University of Delhi. I am aware that disputes if any, arising out of/or relating to any matter whatsoever,concerning registration/cancellation/submission of thesis or any other matter shall be subject to the exclusive jurisdiction of the competent courts in Delhi only.<br />
		b)I declare that i shall submit myself toi the disciplinary jurisdiction of the authorities of the University who may be vested with the powers to exercise discipline under the Act, the statues he Ordinance and the Rules that may be framed by the University/Board from time to time in this behalf.&nbsp; 
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" CssClass="auto-style1" ErrorMessage="Select Department Name." InitialValue="Select Department" ControlToValidate="DropDownListDepartment"></asp:RequiredFieldValidator>
            </strong>
        </div>
        <p class="auto-style75">
            <table class="auto-style54">
                <tr>
                    <td class="auto-style67"><strong>Are you currently employed? </strong></td>
                    <td class="auto-style80">
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged" RepeatDirection="Horizontal">
                            <asp:ListItem>YES</asp:ListItem>
                            <asp:ListItem>NO</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
            <br />
        <table class="auto-style4">
            <tr>
                <td class="auto-style120"><strong>Name of the institution where employed</strong></td>
                <td class="auto-style131" colspan="4">
                    <asp:TextBox ID="TextBox31" runat="server" Enabled="False" OnTextChanged="TextBox31_TextChanged" Width="622px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style120"><strong>Designation</strong></td>
                <td class="auto-style131" colspan="4">
                    <asp:TextBox ID="TextBox32" runat="server" Enabled="False" Width="622px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style119"><strong>Period of employment</strong></td>
                <td class="auto-style133" aria-setsize="180px">From:</td>
                <td class="auto-style133" aria-setsize="180px">
                    <asp:TextBox ID="TextBox33" runat="server" Enabled="False" TextMode="Date">dd/mm/yyyy</asp:TextBox>
                </td>
                <td class="auto-style133" aria-setsize="180px">To:</td>
                <td class="auto-style130" aria-setsize="180px">
                    <asp:TextBox ID="TextBox34" runat="server" Enabled="False" TextMode="Date">dd/mm/yyyy</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style120"><strong>Type of employment</strong></td>
                <td class="auto-style76" colspan="4">
                    <asp:RadioButtonList ID="RadioButtonList3" runat="server" Enabled="False" RepeatDirection="Horizontal" Width="565px">
                        <asp:ListItem>Permanent</asp:ListItem>
                        <asp:ListItem>Temporary</asp:ListItem>
                        <asp:ListItem>Contractual</asp:ListItem>
                        <asp:ListItem>Ad-hoc</asp:ListItem>
                        <asp:ListItem>Project</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style120"><strong>Brief details about the nature of job</strong></td>
                <td class="auto-style134" colspan="4">
                    <asp:TextBox ID="TextBox35" runat="server" Enabled="False" Height="66px" Width="574px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style128"><strong>Office Tel. No.</strong></td>
                <td class="auto-style129" colspan="4">
                    <asp:TextBox ID="TextBox36" runat="server" Enabled="False" TextMode="Number" Width="157px"></asp:TextBox>
                </td>
            </tr>
        </table>
    <p class="auto-style80">
        &nbsp;</p>
        <asp:Button ID="Button3" runat="server" Text="Button2" OnClick="Button3_Click" />
    </form>
    <p class="auto-style80">
        &nbsp;</p>
</body>
</html>
