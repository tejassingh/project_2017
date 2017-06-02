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
            }
        .auto-style6 {
            width: 103px;
            text-align: right;
        }
        .auto-style8 {
            width: 508px;
            text-align: left;
        }
        .auto-style9 {
            width: 103px;
            height: 26px;
            text-align: right;
        }
        .auto-style10 {
            width: 508px;
            height: 26px;
            text-align: left;
        }
        .auto-style11 {
            height: 26px;
            width: 296px;
            text-align: left;
        }
        .auto-style12 {
            height: 26px;
            width: 52px;
            text-align: right;
        }
        .auto-style14 {
            width: 52px;
            text-align: right;
        }
        .auto-style17 {
            width: 103px;
            height: 30px;
            text-align: right;
        }
        .auto-style18 {
            width: 508px;
            height: 30px;
            text-align: left;
        }
        .auto-style19 {
            width: 52px;
            height: 30px;
            text-align: right;
        }
        .auto-style20 {
            width: 296px;
            height: 30px;
            text-align: left;
        }
        .auto-style21 {
            width: 296px;
            text-align: left;
        }
        .auto-style22 {
            color: #FF0000;
        }
        .auto-style24 {
            width: 1004px;
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            height: 2px;
        }
        .auto-style26 {
            height: 23px;
            width: 288px;
            text-align: right;
        }
        .auto-style28 {
            width: 288px;
            text-align: right;
        }
        .auto-style29 {
            width: 288px;
            text-align: right;
            height: 42px;
        }
        .auto-style32 {
            height: 42px;
            width: 45px;
        }
        .auto-style34 {
            height: 23px;
            width: 45px;
        }
        .auto-style35 {
            width: 45px;
        }
        .auto-style37 {
            width: 288px;
            text-align: right;
            height: 26px;
        }
        .auto-style38 {
            width: 45px;
            height: 26px;
        }
        .auto-style40 {
            height: 23px;
            text-align: center;
            width: 216px;
        }
        .auto-style41 {
            height: 42px;
            width: 216px;
        }
        .auto-style42 {
            height: 23px;
            width: 216px;
        }
        .auto-style43 {
            height: 26px;
            width: 216px;
        }
        .auto-style45 {
            height: 23px;
            text-align: center;
            width: 136px;
        }
        .auto-style46 {
            height: 42px;
            width: 136px;
        }
        .auto-style47 {
            height: 23px;
            width: 136px;
        }
        .auto-style48 {
            height: 26px;
            width: 136px;
        }
        .auto-style50 {
            width: 136px;
        }
        .auto-style52 {
            width: 216px;
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
        .auto-style58 {
            text-align: left;
        }
        .auto-style60 {
            margin-left: 0px;
        }
        .auto-style61 {
            width: 112px;
            text-align: right;
        }
        .auto-style62 {
            width: 523px;
            text-align: left;
        }
        .auto-style63 {
            width: 103px;
            text-align: right;
            height: 119px;
        }
        .auto-style64 {
            width: 508px;
            text-align: left;
            height: 119px;
        }
        .auto-style65 {
            width: 52px;
            text-align: right;
            height: 119px;
        }
        .auto-style66 {
            width: 296px;
            text-align: left;
            height: 119px;
        }
        .auto-style67 {
            width: 244px;
        }
        .auto-style68 {
            width: 273px;
        }
        .auto-style70 {
            width: 273px;
            height: 23px;
        }
        .auto-style73 {
            width: 139px;
        }
        .auto-style74 {
            height: 23px;
            width: 139px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong><span class="auto-style2">Department :</span>
            <asp:DropDownList ID="DropDownListDepartment" runat="server">
                <asp:ListItem>Select Department</asp:ListItem>
                <asp:ListItem>Computer Science</asp:ListItem>
                <asp:ListItem>Mathematics</asp:ListItem>
                <asp:ListItem>Operational Research</asp:ListItem>
                <asp:ListItem>Statistics</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="auto-style1" ErrorMessage="Select Department Name." InitialValue="Select Department" ControlToValidate="DropDownListDepartment"></asp:RequiredFieldValidator>
&nbsp;</div>
        <p class="auto-style3">
            <strong>Basic Details:</strong></p>
        <table class="auto-style4">
            <tr>
                <td class="auto-style9"><strong>Address in Delhi:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox_Address_Delhi" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox_Address_Delhi" ErrorMessage="It must be filled" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style12">Pincode:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox_Pincode_Delhi" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox_Pincode_Delhi" CssClass="auto-style22" ErrorMessage="It must be numeric" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">Telephone:</td>
                <td class="auto-style18">
                    <asp:TextBox ID="TextBox_Telephone_Delhi" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox_Telephone_Delhi" CssClass="auto-style22" ErrorMessage="It must be numeric." ValidationExpression="(011)?\d\d \d\d(\d \d| \d\d )\d\d"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style19">Mobile No:</td>
                <td class="auto-style20">
                    <asp:TextBox ID="TextBox_MobileNo" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox_MobileNo" CssClass="auto-style22" ErrorMessage="RegularExpressionValidator" ValidationExpression="(0( \d|\d ))?\d\d \d\d(\d \d| \d\d )\d\d">It must be numeric</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style63">Permanent Address:</td>
                <td class="auto-style64">
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Same as Address in Delhi" />
                    <asp:TextBox ID="TextBox_Per_Add" runat="server" TextMode="MultiLine" Width="500px" OnTextChanged="TextBox_Per_Add_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox_Per_Add" ErrorMessage="It must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style65">Pincode:</td>
                <td class="auto-style66">
                    <asp:TextBox ID="TextBox_Per_Pincode" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox_Per_Pincode" CssClass="auto-style22" ErrorMessage="It must be numeric" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Telephone:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox_Per_Telephone" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox_Per_Telephone" CssClass="auto-style22" ErrorMessage="It must be numeric" ValidationExpression="(0( \d|\d ))?\d\d \d\d(\d \d| \d\d )\d\d"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style14">Mobile No:</td>
                <td class="auto-style21">
                    <asp:TextBox ID="TextBox_Per_MobileNo" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TextBox_Per_MobileNo" ErrorMessage="It must be numeric" ForeColor="Red" ValidationExpression="(0( \d|\d ))?\d\d \d\d(\d \d| \d\d )\d\d"></asp:RegularExpressionValidator>
                    </strong>
                    </strong>
                </td>
            </tr>
        </table>
        <p>
            Father&#39;s/Guardian&#39;s/Husband&#39;s Occupation&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <strong>
			<asp:TextBox ID="TextBox25" runat="server" Width="270px"></asp:TextBox>
			</strong>
        </p>
		<p>
            Mother&#39;s Occupation&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><asp:TextBox ID="TextBox30" runat="server" Width="270px"></asp:TextBox>
			</strong>
        </p>
		<p>
            <table class="auto-style54">
                <tr>
                    <td class="auto-style62">
            <strong>Are you pursuing any other course in this or any other University/Instituition? </strong>
		            </td>
                    <td class="auto-style61">
            <strong>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="auto-style57" RepeatDirection="Horizontal">
                            <asp:ListItem>YES</asp:ListItem>
                            <asp:ListItem>NO</asp:ListItem>
                        </asp:RadioButtonList>
                        </strong>
		            </td>
                    <td class="auto-style58">
            <strong>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged1" Width="200px" CssClass="auto-style60">If Yes,then give details</asp:TextBox>
                        </strong>
		            </td>
                </tr>
            </table>
            &nbsp;
        </p>
		<p>
            Delhi University&#39;s Enrollment Number (if any)&nbsp;&nbsp;&nbsp;
            <strong>
			<asp:TextBox ID="TextBox26" runat="server" Width="270px"></asp:TextBox>
			</strong>
        </p>
        <p>
            &nbsp;</p>
        <p class="auto-style3">
            <strong>Educational Details:</strong></p>
        <table class="auto-style24">
            <tr>
                <td class="auto-style26"><strong>&nbsp;&nbsp;&nbsp; Examination passed:</strong></td>
                <td class="auto-style34"></td>
                <td class="auto-style45"><strong>University</strong></td>
                <td class="auto-style45"><strong>Year</strong></td>
                <td class="auto-style45"><strong>Div./Grade</strong></td>
                <td class="auto-style40"><strong>Subject(s)</strong></td>
            </tr>
            <tr>
                <td class="auto-style29"><strong>B.A/B.Sc./B.Com.(Hons/Pass)/B.B.A./B.Tech.</strong></td>
                <td class="auto-style32"></td>
                <td class="auto-style46">
                    <asp:TextBox ID="TextBox_Grad_Uni" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox_Grad_Uni"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style46">
                    <asp:TextBox ID="TextBox_Grad_year" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox_Grad_year" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style46">
                    <asp:TextBox ID="TextBox_Grad_Div" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox_Grad_Div" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style41">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style26"><strong>M.A./M.Sc./M.C.A./M.Com./M.B.A./M.Tech.</strong></td>
                <td class="auto-style34"></td>
                <td class="auto-style47">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style47">
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style47">
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style42">
                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style37"><strong>M.Phil in </strong></td>
                <td class="auto-style38"><strong>Part -I</strong></td>
                <td class="auto-style48">
                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style48">
                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style48">
                    <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style43">
                    <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style35"><strong>Part-II</strong></td>
                <td class="auto-style50">
                    <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style50">
                    <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style50">
                    <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style52">
                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style28"><strong>Any other Examination passed:</strong></td>
                <td class="auto-style35">&nbsp;</td>
                <td class="auto-style50">
                    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style50">
                    <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style50">
                    <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style52">
                    <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
            </strong>
                </td>
            </tr>
        </table>
    <p>
        &nbsp;</p>
    <p class="auto-style3">
        <strong>Research Details:</strong></p>
		<p class="auto-style53">
        	Fellowship/Scholarship under&nbsp;&nbsp;&nbsp;
            <strong>
			<asp:TextBox ID="TextBox27" runat="server" Width="270px"></asp:TextBox>
			scheme</strong></p>
    <p class="auto-style3">
            <strong><span class="auto-style53">Languages Known: </span>
            <asp:TextBox ID="TextBox_Languages0" runat="server" CssClass="auto-style53" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox_Languages0" ErrorMessage="It must not be empty" ForeColor="Red" CssClass="auto-style53"></asp:RequiredFieldValidator>
            </strong></p>
		Precise details of research experience(if any) </strong>
		<asp:TextBox ID="TextBox28" runat="server" TextMode="MultiLine" Width="376px"></asp:TextBox>
		<br />
&nbsp;<br />
		<strong>Title of the proposed Research Topic&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<asp:TextBox ID="TextBox29" runat="server" TextMode="MultiLine" Width="376px"></asp:TextBox>
		<br />
		<br />
		<span class="auto-style3">UNDERTAKING DECLARATION:<br />
		<br />
		</span>a) I have carefully gone through the rules as prescribed under Ordinance-VIB and by the Board relating to the Doctories of Philosphy (Ph.D)Course and I undertake to abide by them during the tenure of my research in the department of
            <asp:DropDownList ID="DropDownListDepartment0" runat="server">
                <asp:ListItem>Select Department</asp:ListItem>
                <asp:ListItem>Computer Science</asp:ListItem>
                <asp:ListItem>Mathematics</asp:ListItem>
                <asp:ListItem>Operational Research</asp:ListItem>
                <asp:ListItem>Statistics</asp:ListItem>
            </asp:DropDownList>
            &nbsp; <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" CssClass="auto-style1" ErrorMessage="Select Department Name." InitialValue="Select Department" ControlToValidate="DropDownListDepartment"></asp:RequiredFieldValidator>
&nbsp;University of Delhi. I am aware that disputes if any, arising out of/or relating to any matter whatsoever,concerning registration/cancellation/submission of thesis or any other matter shall be subject to the exclusive jurisdiction of the competent courts in Delhi only.<br />
		b)I declare that i shall submit myself toi the disciplinary jurisdiction of the authorities of the University who may be vested with the powers to exercise discipline under the Act, the statues he Ordinance and the Rules that may be framed by the University/Board from time to time in this behalf.&nbsp; </strong>
        <p>
            &nbsp;</p>
        <p>
            <table class="auto-style54">
                <tr>
                    <td class="auto-style67"><strong>Are you currently employed? </strong></td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged" RepeatDirection="Horizontal">
                            <asp:ListItem>YES</asp:ListItem>
                            <asp:ListItem>NO</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
            <strong>&nbsp;</strong></p>
        <table class="auto-style54">
            <tr>
                <td class="auto-style68">Name of the institution where employed</td>
                <td class="auto-style73" colspan="4">
                    <asp:TextBox ID="TextBox31" runat="server" Enabled="False" OnTextChanged="TextBox31_TextChanged" Width="622px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style68">Designation</td>
                <td class="auto-style73" colspan="4">
                    <asp:TextBox ID="TextBox32" runat="server" Enabled="False" Width="622px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style70">Period of employment</td>
                <td class="auto-style74">&nbsp;&nbsp; From:</td>
                <td class="auto-style74">
                    <asp:TextBox ID="TextBox33" runat="server" Enabled="False" TextMode="Date">dd/mm/yyyy</asp:TextBox>
                </td>
                <td class="auto-style74">To:</td>
                <td class="auto-style74">
                    <asp:TextBox ID="TextBox34" runat="server" Enabled="False" TextMode="Date">dd/mm/yyyy</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style68">Type of employment</td>
                <td class="auto-style73" colspan="4">
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
                <td class="auto-style68">Brief details about the nature of job</td>
                <td class="auto-style73" colspan="4">
                    <asp:TextBox ID="TextBox35" runat="server" Enabled="False" Height="66px" Width="574px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style68">Office Tel. No.</td>
                <td class="auto-style73" colspan="4">
                    <asp:TextBox ID="TextBox36" runat="server" Enabled="False" TextMode="Number" Width="157px"></asp:TextBox>
                </td>
            </tr>
        </table>
    <p>
        &nbsp;</p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
