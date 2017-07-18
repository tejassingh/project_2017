<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adm_form.aspx.cs" Inherits="PhD.admission_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href = "https://code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css" rel = "stylesheet" />
    <script src = "https://code.jquery.com/jquery-1.10.2.js"></script>
    <script src = "https://code.jquery.com/ui/1.10.4/jquery-ui.js"></script>

 
    <script type="text/javascript">



        function Departmentindexchange() {
            var ddmenu = document.getElementById('DropDownListDepartment');
            var txt = ddmenu.options[ddmenu.selectedIndex].text;
            var txtbox = document.getElementById("TextBox37").value = txt;


           // document.getElementById("Label1").innerHTML=txt;
            
          // document.getElementById("demo").style.backgroundColor='gray';
            document.getElementById("demo").innerHTML=txt;
            document.getElementById("demo").style.backgroundColor='gray';
            //txtbox.text = txt;
                  
            //alert(txt);        
        }

        function Sameaddrchange() {
            var chckbx = document.getElementById("CheckBox1").checked;
            
            var txtbox1 = document.getElementById("TextBox_Address_Delhi");
            var txtbox2 = document.getElementById("TextBox_Per_Add");
            var txtbox3 = document.getElementById("TextBox_Pincode_Delhi");
            var txtbox4 = document.getElementById("TextBox_Per_Pincode");
            if (chckbx == true) {
                txtbox2.value = txtbox1.value;
                txtbox4.value = txtbox3.value;
            }
            else {
                txtbox2.value = "";
                txtbox4.value = "";
            }
        }

        function tabswitch(str1) {
            if (Page_ClientValidate(str1))
                return true;
            else
                return false;


        }

        $(document).ready(function () {
            $('#tabs').tabs();
            var currTab = $("#<%= Hdnfldtabs.ClientID %>").val();

            
            $('#tabs').tabs("option", "active", currTab);
            var arr1 = [0, 1, 2, 3,4];

            arr1.splice(currTab, 1);
            $('#tabs').tabs("option", "disabled", arr1);
            






      /*        $('#Next1').click(function () {
                $('#tabs').tabs("enable", 1);
                $('#tabs').tabs("option", "active", 1);
                $('#tabs').tabs("disable", 0);
            });
    
            $('#Previous1').click(function () {
                $('#tabs').tabs("enable", 0);
                $('#tabs').tabs("option", "active", 0);
                $('#tabs').tabs("disable", 1);
            });
            $('#Next2').click(function () {
                $('#tabs').tabs("enable", 2);
                $('#tabs').tabs("option", "active", 2);
                $('#tabs').tabs("disable", 1);
            });
            $('#Previous2').click(function () {
                $('#tabs').tabs("enable", 1);
                $('#tabs').tabs("option", "active", 1);
                $('#tabs').tabs("disable", 2);
            });
            $('#Next3').click(function () {
                $('#tabs').tabs("enable", 3);
                $('#tabs').tabs("option", "active", 3);
                $('#tabs').tabs("disable", 2);
            });
            $('#Previous3').click(function () {
                $('#tabs').tabs("enable", 2);
                $('#tabs').tabs("option", "active", 2);
                $('#tabs').tabs("disable", 3);
            });
            */
            $('#Next4').click(function () {
                alert('Submitted Succesfully')
            });
            
            
        });
    </script>

   
    
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
            width: 133px;
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
            width: 133px;
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
        .auto-style94 {
            height: 21px;
            text-align: justify;
            width: 160px;
        }
        .auto-style103 {
            height: 39px;
            width: 160px;
            text-align: justify;
        }
        .auto-style105 {
            height: 39px;
            width: 150px;
            text-align: right;
        }
        .auto-style106 {
            height: 39px;
            width: 220px;
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
            width: 1004px;
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            height: 337px;
        }
        .auto-style135 {
            text-align: justify;
            margin-left: 200px;
        }
        .auto-style137 {
            margin-left: 80px;
        }
        .auto-style138 {
            margin-left: 41px;
        }
        .auto-style139 {
            width: 100%;
            border-style: solid;
            border-width: 3px;
        }
        .auto-style140 {
            width: 175px;
        }
        .auto-style141 {
            width: 202px;
        }
        .auto-style143 {
            width: 160px;
        }
        .auto-style144 {
            width: 2px;
        }
        .auto-style145 {
            width: 364px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <asp:HiddenField ID="Hdnfldtabs" runat="server" Value="0" />
        <asp:HiddenField ID="department_hidden" runat="server" />


        <div id="tabs">
            <ul>
                <li><a href="#Basic">Basic Details</a></li>
                <li><a href="#Research">Research Details</a></li>
                <li><a href="#Upload_Doc">Upload Documents</a></li>
                <li><a href="#Submit_Form">Submit Form</a></li>
                <li><a href="#Print_Form">Print Form</a></li>
            </ul>
            <div id="Basic">

              
        <div class="auto-style80">
            <strong><span class="auto-style2">Department :</span>
            <asp:DropDownList ID="DropDownListDepartment" runat="server" >
                <asp:ListItem>Select Department</asp:ListItem>
                <asp:ListItem>Computer Science</asp:ListItem>
                <asp:ListItem>Mathematics</asp:ListItem>
                <asp:ListItem>Operational Research</asp:ListItem>
                <asp:ListItem>Statistics</asp:ListItem>
            </asp:DropDownList>

          
                



            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="auto-style1" ErrorMessage="Select Department Name." InitialValue="Select Department" ControlToValidate="DropDownListDepartment" ValidationGroup="page1" ValidateRequestMode="Enabled"></asp:RequiredFieldValidator>
&nbsp;<br />
                </div>
        <p class="auto-style77">
            <strong>Basic Details:</strong></p>
        <table class="auto-style4">
            <tr>
                <td class="auto-style9"><strong>Address in Delhi:<span class="auto-style22">&nbsp; *</span></td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox_Address_Delhi" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox_Address_Delhi" ErrorMessage="It must be filled" ForeColor="Red" ValidationGroup="page1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style12">Pincode:&nbsp; <span class="auto-style22">*</span></td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox_Pincode_Delhi" runat="server" CausesValidation="True" MaxLength="6"></asp:TextBox>
                    <br />
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox_Pincode_Delhi" ErrorMessage="Enter a valid pincode" ForeColor="Red" MaximumValue="110999" MinimumValue="110000" Type="Integer" ValidationGroup="page1"></asp:RangeValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox_Pincode_Delhi" ErrorMessage="Pin code cannot be empty" ForeColor="Red" ValidationGroup="page1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Telephone:&nbsp;</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox_Telephone_Delhi" runat="server" CausesValidation="True" MaxLength="12" ></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox_Telephone_Delhi" CssClass="auto-style22" ErrorMessage="It must be numeric." ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}" ValidateRequestMode="Disabled"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style12">Mobile No:&nbsp; <span class="auto-style22">*</span><br />
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox_MobileNo" runat="server" CausesValidation="True" MaxLength="10"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox_MobileNo" CssClass="auto-style22" ErrorMessage="It must be numeric" ValidationExpression="\d{10}" ValidateRequestMode="Disabled" ValidationGroup="page1"></asp:RegularExpressionValidator>
            <strong>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBox_MobileNo" ErrorMessage="Enter Mobile no." ForeColor="Red" ValidationGroup="page1"></asp:RequiredFieldValidator>
            </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style63">Permanent Address: <span class="auto-style22">*</span></td>
                <td class="auto-style64">
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="false" onchange="Sameaddrchange()" Text="Same as Address in Delhi" Width="250px" />
                    <asp:TextBox ID="TextBox_Per_Add" runat="server" TextMode="MultiLine" Width="500px" OnTextChanged="TextBox_Per_Add_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox_Per_Add" ErrorMessage="It must not be empty" ForeColor="Red" ValidationGroup="page1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style65">Pincode:</td>
                <td class="auto-style63">
                    <asp:TextBox ID="TextBox_Per_Pincode" runat="server" MaxLength="6"></asp:TextBox>
                    <br />
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="TextBox_Per_Pincode" ErrorMessage="Enter a valid Pincode" ForeColor="Red" MaximumValue="110999" MinimumValue="110000" ValidationGroup="page1"></asp:RangeValidator>
                    <br />
            <strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBox_Per_Pincode" ErrorMessage="Pin code cannot be empty" ForeColor="Red" ValidationGroup="page1"></asp:RequiredFieldValidator>
            </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style63">Telephone:</td>
                <td class="auto-style64">
                    <asp:TextBox ID="TextBox_Per_Telephone" runat="server" MaxLength="10"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox_Per_Telephone" CssClass="auto-style22" ErrorMessage="It must be numeric" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                    <br />
                </td>
                <td class="auto-style65">Mobile No:</td>
                <td class="auto-style63">
                    <asp:TextBox ID="TextBox_Per_MobileNo" runat="server" MaxLength="10"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TextBox_Per_MobileNo" ErrorMessage="It must be numeric" ForeColor="Red" ValidationExpression="\d{10}" ValidationGroup="page1"></asp:RegularExpressionValidator>
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
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="auto-style57" RepeatDirection="Horizontal" Width="187px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                            <asp:ListItem>YES</asp:ListItem>
                            <asp:ListItem>NO</asp:ListItem>
                        </asp:RadioButtonList>
                        </strong>
		            </td>
                <td>
            <strong>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged1" Width="308px" CssClass="auto-style60">If Yes,then give details</asp:TextBox>
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
                <td class="auto-style140" style="border-style: solid; border-width: thin"><strong>Examination passed:</strong></td>
                <td class="auto-style94" style="border-style: solid; border-width: thin"><strong>University</strong></td>
                <td class="auto-style94" style="border-style: solid; border-width: thin"><strong>Year</strong></td>
                <td class="auto-style94" style="border-style: solid; border-width: thin"><strong>Div./Grade</strong></td>
                <td class="auto-style138" style="border-style: solid; border-width: thin"><strong>Subject(s)</strong></td>
            </tr>
            <tr>
                <td class="auto-style141" style="border-style: solid; border-width: thin">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="ui-priority-primary" Height="54px" Width="135px">
                        <asp:ListItem>B.A.</asp:ListItem>
                        <asp:ListItem>B.Sc.</asp:ListItem>
                        <asp:ListItem>B.Com(hons.)</asp:ListItem>
                        <asp:ListItem>B.Com.(Pass)</asp:ListItem>
                        <asp:ListItem>B.Tech.</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select Graduation Course" ForeColor="Red" ValidationGroup="page1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox_Grad_Uni" runat="server" Height="39px" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ValidationGroup="page1" ForeColor="Red" ControlToValidate="TextBox_Grad_Uni"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox_Grad_year" runat="server" Height="39px" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox_Grad_year" ValidationGroup="page1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox_Grad_year" ErrorMessage="Year must be in 1980-2014" ForeColor="Red" MaximumValue="2014" MinimumValue="1980" ValidationGroup="page1"></asp:RangeValidator>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox_Grad_Div" runat="server" Height="39px" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox_Grad_Div" ValidationGroup="page1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="TextBox_Grad_Div" ErrorMessage="Division must be in 1-3" ForeColor="Red" MaximumValue="3" MinimumValue="1" ValidationGroup="page1"></asp:RangeValidator>
                </td>
                <td class="auto-style106">
                    <asp:TextBox ID="TextBox8" runat="server" Height="39px" OnTextChanged="TextBox8_TextChanged" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="TextBox8" ErrorMessage="*" ForeColor="Red" ValidationGroup="page1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style141" style="border-style: solid; border-width: thin">
                    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="ui-priority-primary" Height="16px" Width="134px">
                        <asp:ListItem>M.A.</asp:ListItem>
                        <asp:ListItem>M.C.A</asp:ListItem>
                        <asp:ListItem>M.Sc.</asp:ListItem>
                        <asp:ListItem>M.Com.</asp:ListItem>
                        <asp:ListItem>M.Tech</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Select Masters Course" ForeColor="Red" ValidationGroup="page1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox9" runat="server" Height="39px" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="TextBox9" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="page1">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox10" runat="server" Height="39px" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="TextBox10" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="page1">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="TextBox10" ErrorMessage="Year must be in 1983-2017" ForeColor="Red" MaximumValue="2017" MinimumValue="1983" ValidationGroup="page1"></asp:RangeValidator>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox11" runat="server" Height="39px" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="TextBox11" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="page1">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="TextBox11" ErrorMessage="Division must be in 1-3" ForeColor="Red" MaximumValue="3" MinimumValue="1" ValidationGroup="page1"></asp:RangeValidator>
                </td>
                <td class="auto-style139">
                    <asp:TextBox ID="TextBox12" runat="server" Height="39px" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="TextBox12" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="page1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style141" style="border-style: solid; border-width: thin"><strong>M.Phil<br />
                    in&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Part -I</strong></td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox13" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox14" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox15" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style139">
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
                <td class="auto-style139">
                    <asp:TextBox ID="TextBox20" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style141" style="border-style: solid; border-width: thin"><strong>Any other Examination passed:</strong></td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox21" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox22" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="TextBox23" runat="server" Height="39px" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style139">
                    <asp:TextBox ID="TextBox24" runat="server" Height="39px" Width="160px"></asp:TextBox>
            </strong>
                </td>
            </tr>
        </table>
                <p class="auto-style135">
                    <asp:Button ID="Next1" runat="server" Text="Save &amp; Next" Width="201px" OnClick="Next1_Click" ValidationGroup="page1" CssClass="ui-priority-primary"   />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Button ID="test1" runat="server" Text="Test" OnClick="test1_Click" />
                </p>
                <p class="auto-style80">
                    &nbsp;</p>
    </div>
    <div id="Research">
    <p class="auto-style77">
        <strong>Research Details:</strong></p>
        <table class="auto-style4">
            <tr>
                <td class="auto-style109">
            <strong>Fellowship/Scholarship under</strong></td>
                <td class="auto-style110">
            <strong>
			<asp:TextBox ID="TextBox27" runat="server" Width="273px" Height="28px"></asp:TextBox>
			scheme</strong></td>
            </tr>
            <tr>
                <td class="auto-style109">
            <strong><span class="auto-style2">Languages Known:&nbsp; <span class="auto-style22">*</span></span></strong></td>
                <td class="auto-style110"><strong>
            <asp:TextBox ID="TextBox_Languages0" runat="server" CssClass="auto-style53" TextMode="MultiLine"></asp:TextBox>
                    <span class="auto-style53">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox_Languages0" ErrorMessage="It must not be empty" ForeColor="Red" CssClass="auto-style2" ValidationGroup="page2"></asp:RequiredFieldValidator>
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
		
        <p class="auto-style75">
            <table class="auto-style54">
                <tr>
                    <td class="auto-style67"><strong>Are you currently employed?&nbsp; </strong></td>
                    <td class="auto-style80">
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged" RepeatDirection="Horizontal">
                            <asp:ListItem>YES</asp:ListItem>
                            <asp:ListItem>NO</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ErrorMessage="Select Yes/No" ForeColor="Red" ValidationGroup="page2" ControlToValidate="RadioButtonList2">*</asp:RequiredFieldValidator>
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
                <td class="auto-style131" colspan="4">
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
        &nbsp;&nbsp;&nbsp; </p>
        <p class="auto-style80">
        &nbsp;<strong>Download the document and get attested by the Head of the Department&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="button_download" runat="server" Width="167px" CausesValidation="False" OnClick="button_download_Click" Text="Download" CssClass="auto-style138" />
            </strong><br />
           <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <asp:Button ID="Button3" runat="server" Text="Button2" OnClick="Button3_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><asp:Button ID="Previous1" runat="server" OnClick="Button4_Click" Text="Previous" ValidationGroup="page1" />
            </strong>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <strong>
        <asp:Button ID="Next2" runat="server" Text="Next" Width="70px" OnClick="Next2_Click" ValidationGroup="page2" />
            </strong>
    </div>
    <div id="Upload_Doc" class="auto-style137">
           <strong>&nbsp; </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <table class="auto-style139">
               <tr>
                   <td class="auto-style140"><strong>CLASS XII CERTIFICATE</strong></td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload1" runat="server" />
                   </td>
                   <td class="auto-style144">
                   </td>
                   <td class="auto-style143">&nbsp;&nbsp;
                       <asp:Button ID="Button_upload1" runat="server" OnClick="upload_button1_Click" CausesValidation="False" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Labelxii_certi" runat="server"></asp:Label>
                       &nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="FileUpload1" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style140"><strong>CLASS X CERTIFICATE</strong></td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload2" runat="server" />
                   </td>
                   <td class="auto-style144">
                       &nbsp;</td>
                   <td class="auto-style143">&nbsp;&nbsp;&nbsp;
                       <asp:Button ID="Button_upload2" runat="server" OnClick="upload_button2_Click" CausesValidation="False" style="width: 99px" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;&nbsp;
                       <asp:Label ID="Labelx_certi" runat="server"></asp:Label>
                       &nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="FileUpload2" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style140"><strong>CLASS XII MARKSHEET</strong></td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload3" runat="server" />
                   </td>
                   <td class="auto-style144">
                       &nbsp;</td>
                   <td class="auto-style143">&nbsp;&nbsp;
                       <asp:Button ID="Button_upload3" runat="server" OnClick="upload_button3_Click" CausesValidation="False" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;&nbsp;
                       <asp:Label ID="Labelxii_marksheet" runat="server"></asp:Label>
                       &nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="FileUpload3" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style140"><strong>CLASS X MARKSHEET</strong><br />
                   </td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload4" runat="server" />
                   </td>
                   <td class="auto-style144">
                       &nbsp;</td>
                   <td class="auto-style143">&nbsp;&nbsp;
                       <asp:Button ID="Button_upload4" runat="server" OnClick="upload_button4_Click" CausesValidation="False" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;&nbsp;
                       <asp:Label ID="Labelx_marksheet" runat="server"></asp:Label>
                       &nbsp;&nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="FileUpload4" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style140"><strong>GRADUATION MARKSHEET</strong><br />
                   </td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload5" runat="server" />
                   </td>
                   <td class="auto-style144">
                       &nbsp;</td>
                   <td class="auto-style143">&nbsp;&nbsp;
                       <asp:Button ID="Button_upload5" runat="server" OnClick="upload_button5_Click"  CausesValidation="False" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;&nbsp;
                       <asp:Label ID="Labelgrad_marksheet" runat="server"></asp:Label>
                       &nbsp;&nbsp;&nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="FileUpload5" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style140"><strong>POST-GRADUATION<br />
                       MARKSHEET</strong></td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload6" runat="server" />
                   </td>
                   <td class="auto-style144">
                       &nbsp;</td>
                   <td class="auto-style143">&nbsp;&nbsp;
                       <asp:Button ID="Button_upload6" runat="server" OnClick="upload_button6_Click" CausesValidation="False" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;&nbsp;
                       <asp:Label ID="Labelpg_marksheet" runat="server"></asp:Label>
                       &nbsp;&nbsp;&nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ControlToValidate="FileUpload6" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style140"><strong>GRADUATION CERTIFICATE</strong></td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload7" runat="server" />
                   </td>
                   <td class="auto-style144">
                       &nbsp;</td>
                   <td class="auto-style143">&nbsp;&nbsp;
                       <asp:Button ID="Button_upload7" runat="server" OnClick="upload_button7_Click" CausesValidation="False" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;
                       <asp:Label ID="Labelgrad_certi" runat="server"></asp:Label>
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="FileUpload7" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style140"><strong>POST GRADUATION CERTIFICATE</strong></td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload8" runat="server" />
                   </td>
                   <td class="auto-style144">
                       &nbsp;</td>
                   <td class="auto-style143">&nbsp;&nbsp;
                       <asp:Button ID="Button_upload8" runat="server" OnClick="upload_button8_Click" CausesValidation="False" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;
                       <asp:Label ID="Labelpg_certi" runat="server"></asp:Label>
                       &nbsp;&nbsp;&nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ControlToValidate="FileUpload8" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
               </tr>
               <tr>
                   <td class="auto-style140"><strong>DOCUMENT ATTESTED BY HOD</strong></td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload9" runat="server" />
                   </td>
                   <td class="auto-style144">
                       &nbsp;</td>
                   <td class="auto-style143">&nbsp;&nbsp;
                       <asp:Button ID="Button_upload9" runat="server" OnClick="upload_button9_Click" CausesValidation="False" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;
                       <asp:Label ID="Labeldoc_hod" runat="server"></asp:Label>
                       &nbsp;&nbsp;&nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="FileUpload9" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style140"><strong>SIGNATURE</strong></td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload10" runat="server" />
                   </td>
                   <td class="auto-style144">
                       &nbsp;</td>
                   <td class="auto-style143">&nbsp;&nbsp;
                       <asp:Button ID="Button_upload10" runat="server" OnClick="upload_button10_Click" CausesValidation="False" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;
                       <asp:Label ID="Labelsignature" runat="server"></asp:Label>
                       &nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="FileUpload10" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style140">P<strong>HOTO</strong></td>
                   <td class="auto-style141">
                       <asp:FileUpload ID="FileUpload11" runat="server" />
                   </td>
                   <td class="auto-style144">
                       &nbsp;</td>
                   <td class="auto-style143">&nbsp;
                       <asp:Button ID="Button_upload11" runat="server" OnClick="upload_button11_Click" CausesValidation="False" Text="Upload File" />
                       &nbsp;</td>
                   <td class="auto-style145">&nbsp;
                       <asp:Label ID="Labelphoto" runat="server"></asp:Label>
                       &nbsp;&nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="FileUpload11" ErrorMessage="Field must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style140">&nbsp;</td>
                   <td class="auto-style141">&nbsp;</td>
                   <td class="auto-style144">&nbsp;</td>
                   <td class="auto-style143">&nbsp;</td>
                   <td class="auto-style145">&nbsp;</td>
               </tr>
           </table>
        
           <br />
        
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Image ID="Image1" runat="server" CssClass="auto-style60" Height="183px" Width="195px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
           <br />
        
           <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <br />
           <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="test_txt1" ErrorMessage="Field must not be empty" ForeColor="Red" ValidationGroup="page3"></asp:RequiredFieldValidator>
           <br />
           <br />
        
           <br />
        
           <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:TextBox ID="test_txt1" runat="server"></asp:TextBox>
           <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="test_txt1" ErrorMessage="Field must not be empty" ForeColor="Red" ValidationGroup="page3"></asp:RequiredFieldValidator>
           <br />
           <br />
        
           <br />
           <br />
        
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><asp:Button ID="Previous2" runat="server" OnClick="Previous2_Click" Text="Previous" ValidationGroup="page2" />
            </strong>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <strong>
        <asp:Button ID="Next3" runat="server" Text="Next" Width="70px" OnClick="Next3_Click" ValidationGroup="page3" />
            </strong>

    </div>
    <div id="Submit_Form">


        <div class="auto-style134">
		    <span class="auto-style3">
            <br />
            UNDERTAKING DECLARATION:<br />
		    <br />
		</span>I have carefully gone through the rules as prescribed under Ordinance-VIB and by the Board relating to the Doctories of Philosphy (Ph.D)Course and I undertake to abide by them during the tenure of my research in the department of <asp:TextBox ID="TextBoxD2" runat="server" BorderStyle="None"></asp:TextBox>
            University of Delhi. I am aware that disputes if any, arising out of/or relating to any matter whatsoever,concerning registration/cancellation/submission of thesis or any other matter shall be subject to the exclusive jurisdiction of the competent courts in Delhi only.<br />
		    <br />
            I declare that i shall submit myself toi the disciplinary jurisdiction of the authorities of the University who may be vested with the powers to exercise discipline under the Act, the statues he Ordinance and the Rules that may be framed by the University/Board from time to time in this behalf.&nbsp; 
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" CssClass="auto-style1" ErrorMessage="Select Department Name." InitialValue="Select Department" ControlToValidate="DropDownListDepartment" ValidationGroup="page4"></asp:RequiredFieldValidator>
            </strong>
        </div>

        <br />
&nbsp;
        <br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><asp:Button ID="Previous3" runat="server" OnClick="Previous3_Click" Text="Previous" ValidationGroup="page3" />
            </strong>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <strong>
        <asp:Button ID="Next4" runat="server" Text="Submit" Width="70px" ValidationGroup="page4" OnClick="Next4_Click1" />
            <br />
        <br />
        <br />
        <br />
        <br />
            </strong>

    </div>
            <div id="Print_Form">

                <br />
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Button ID="Button2" runat="server" Text="View Form" OnClick="Button2_Click1" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Button ID="Button4" runat="server" Text="Print Form" OnClick="Button4_Click1" />

            </div>
    </div>
    </form>
    <p class="auto-style80">
        &nbsp;</p>
</body>
</html>
