<%@ Page Language="C#" AutoEventWireup="true" CodeFile="display_form.aspx.cs" Inherits="display_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>



    
     
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: none;
        }
        .auto-style2 {
            width: 365px;
            text-align: left;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 157px;
        }
        .auto-style6 {
            height: 23px;
            width: 157px;
        }
        .auto-style7 {
            width: 443px;
        }
        .auto-style8 {
            height: 23px;
            width: 443px;
        }
        .auto-style9 {
            width: 149px;
        }
        .auto-style10 {
            height: 23px;
            width: 149px;
        }
        .auto-style11 {
            width: 321px;
        }
        .auto-style12 {
            text-decoration: underline;
        }
        .auto-style13 {
            width: 198px;
        }
        .auto-style14 {
            width: 227px;
        }
        .auto-style15 {
            text-align: center;
        }
        .auto-style16 {
            width: 227px;
            text-align: center;
        }
        .auto-style17 {
            width: 198px;
            text-align: center;
        }
        .auto-style18 {
            text-align: center;
            width: 110px;
        }
        .auto-style19 {
            width: 110px;
        }
        .auto-style20 {
            text-align: center;
            width: 131px;
        }
        .auto-style21 {
            width: 131px;
        }
        .auto-style22 {
            width: 198px;
            height: 23px;
        }
        .auto-style23 {
            width: 227px;
            height: 23px;
        }
        .auto-style24 {
            width: 110px;
            height: 23px;
        }
        .auto-style25 {
            width: 131px;
            height: 23px;
        }
        .auto-style27 {
            width: 91px;
            text-align: left;
        }
        .auto-style28 {
            width: 91px;
            height: 23px;
            text-align: left;
        }
        .auto-style29 {
            width: 299px;
        }
        .auto-style30 {
            width: 299px;
            height: 23px;
        }
        .auto-style34 {
            width: 82px;
        }
        .auto-style37 {
            width: 82px;
            height: 23px;
        }
        .auto-style38 {
            width: 263px;
        }
        .auto-style39 {
            width: 263px;
            height: 23px;
        }
        .auto-style40 {
            width: 86px;
        }
        .auto-style41 {
            height: 23px;
            width: 86px;
        }
        .auto-style44 {
            width: 229px;
        }
        .auto-style45 {
            height: 23px;
            width: 229px;
        }
        .auto-style46 {
            width: 108px;
        }
        .auto-style47 {
            width: 108px;
            height: 23px;
        }
    </style>



    
     
</head>
<body>
    <form id="form1" runat="server">
    <p class="auto-style15">
        &nbsp;&nbsp; User -
        <asp:Label ID="Label_UserID" runat="server" Text="Label_UserID"></asp:Label>
        &nbsp;</p>
        <p>
        The Chairman<br />
        Board of Research Studies(Mathematical Sciences)<br />
        New Academic Block<br />
        University of Delhi<br />
        Delhi-110007<br />
    </p>
    <p>
        Through the Head,<br />
        <asp:Label ID="Label_Department" runat="server" Text="Label_Department"></asp:Label>&nbsp;Department</p>
    <p>
        Dear Sir/Madam,<br />
        I am submitting my application for registeration/admission to Ph.D Course in the Department of <asp:Label ID="LabelDepart" runat="server" Text="Label_Department"></asp:Label>  &nbsp;University of Delhi, and am giving below my particulars for consideration of the board.</p>
        <p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Name:</td>
                    <td>
                        <asp:Label ID="Label_Name" runat="server" Text="Label_Name"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Father&#39;s/Husband&#39;s/Gaurdian&#39;s Name</td>
                    <td>
                        <asp:Label ID="Label_FathersName" runat="server" Text="Label_FathersName"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Mother&#39;s Name</td>
                    <td>
                        <asp:Label ID="Label_MothersName" runat="server" Text="Label_MothersName"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Date of Birth</td>
                    <td>
                        <asp:Label ID="Label_DOB" runat="server" Text="Label_DOB"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nationality</td>
                    <td>
                        <asp:Label ID="Label_Nationality" runat="server" Text="Label_Nationality"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Marital Status:</td>
                    <td>
                        <asp:Label ID="Label_MaritalStatus" runat="server" Text="Label_MaritalStatus"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Delhi University Enrollment number(if any)</td>
                    <td>
                        <asp:Label ID="Label_DUEnrollno" runat="server" Text="Label_DUEnrollno"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Whether belong to Scheduled Caste/Scheduled Tribe/OBC</td>
                    <td>
                        <asp:Label ID="Label_SCSTOBC" runat="server" Text="Label_SCSTOBC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Whether Physically Challenged </td>
                    <td>
                        <asp:Label ID="Label_PhysChallenged" runat="server" Text="Label_PhysChallenged"></asp:Label>
                    </td>
                </tr>
            </table>
        </p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Address in Delhi:</td>
                <td class="auto-style7">
                    <asp:Label ID="Label_AddressDelhi" runat="server" Text="Label_AddressDelhi"></asp:Label>
                </td>
                <td class="auto-style9">Pincode:</td>
                <td>
                    <asp:Label ID="Label_PincodeDelhi" runat="server" Text="Label_PincodeDelhi"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Telephone:</td>
                <td class="auto-style7">
                    <asp:Label ID="Label_TelnoDelhi" runat="server" Text="Label_TelnoDelhi"></asp:Label>
                </td>
                <td class="auto-style9">Mobile No:</td>
                <td>
                    <asp:Label ID="Label_MobnoDelhi" runat="server" Text="Label_MobnoDelhi"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Permanent Address:</td>
                <td class="auto-style8">
                    <asp:Label ID="Label_PerAddress" runat="server" Text="Label_PerAddress"></asp:Label>
                </td>
                <td class="auto-style10">Pincode:</td>
                <td class="auto-style4">
                    <asp:Label ID="Label_PerPincode" runat="server" Text="Label_PerPincode"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Telephone:</td>
                <td class="auto-style7">
                    <asp:Label ID="Label_PerTelno" runat="server" Text="Label_PerTelno"></asp:Label>
                </td>
                <td class="auto-style9">Mobile No:</td>
                <td>
                    <asp:Label ID="Label_PerMobno" runat="server" Text="Label_PerMobno"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style11">Father&#39;s/Husband&#39;s/Gaurdian&#39;s Occupation:</td>
                <td>
                    <asp:Label ID="Label_FathersOccu" runat="server" Text="Label_FathersOccu"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Mother&#39;s Occupation</td>
                <td>
                    <asp:Label ID="Label_MothersOccu" runat="server" Text="Label_MothersOccu"></asp:Label>
                </td>
            </tr>
        </table>
        <p>
            Are you pursuing any other course in this or any other University/Instituition?
            <asp:Label ID="Label_OtherUni" runat="server" CssClass="auto-style12" Text="Label_OtherUni"></asp:Label>
        </p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style17">Examination Passed</td>
                <td class="auto-style27">&nbsp;</td>
                <td class="auto-style16">University</td>
                <td class="auto-style18">Year</td>
                <td class="auto-style20">Division</td>
                <td class="auto-style15">Subjects</td>
            </tr>
            <tr>
                <td class="auto-style13">
                    <asp:Label ID="Label_GradCourse" runat="server" Text="Label_GradCourse"></asp:Label>
                </td>
                <td class="auto-style27">
                    &nbsp;</td>
                <td class="auto-style14">
                    <asp:Label ID="Label_GradUni" runat="server" Text="Label_GradUni"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:Label ID="LabelGradYear" runat="server" Text="Label_GradYear"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:Label ID="Label_GradDiv" runat="server" Text="Label_GradDiv"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label_GradSub" runat="server" Text="Label_GradSub"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:Label ID="Label_PGradCourse" runat="server" Text="Label_PGradCourse"></asp:Label>
                </td>
                <td class="auto-style28">
                    &nbsp;</td>
                <td class="auto-style23">
                    <asp:Label ID="Label_PGradUni" runat="server" Text="Label_PGradUni"></asp:Label>
                </td>
                <td class="auto-style24">
                    <asp:Label ID="Label_PGradYear" runat="server" Text="Label_PGradYear"></asp:Label>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label_PGradDiv" runat="server" Text="Label_PGradDiv"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label_PGradSub" runat="server" Text="Label_PGradSub"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">
                    Mphil&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="auto-style28">
                    Part I</td>
                <td class="auto-style23">
                    <asp:Label ID="Label_MphilIUni" runat="server" Text="Label_MphilIUni"></asp:Label>
                </td>
                <td class="auto-style24">
                    <asp:Label ID="Label_MphilIYear" runat="server" Text="Label_MphilIYear"></asp:Label>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label_MphilIDiv" runat="server" Text="Label_MphilIDiv"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label_MphilISub" runat="server" Text="Label_MphilISub"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">
                </td>
                <td class="auto-style28">
                    Part II</td>
                <td class="auto-style23">
                    <asp:Label ID="Label_MphilIIUni" runat="server" Text="Label_PhilIIUni"></asp:Label>
                </td>
                <td class="auto-style24">
                    <asp:Label ID="Label_MphilIIYear" runat="server" Text="Label_MphilIIYear"></asp:Label>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label_MphilIIDiv" runat="server" Text="Label_MphilIIDiv"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label_MphilIISub" runat="server" Text="Label_MphilIISub"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">
                    Any Other Examination Passed
                </td>
                <td class="auto-style27">
                    <asp:Label ID="Label_Anyotherexam" runat="server" Text="Label_Anyotherexam"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:Label ID="Label_AnyotherUni" runat="server" Text="Label_AnyotherUni"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:Label ID="Label_AnyotherYear" runat="server" Text="Label_AnyotherYear"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:Label ID="Label_AnyotherDiv" runat="server" Text="Label_AnyotherDiv"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label_AnyotherSub" runat="server" Text="Label_AnyotherSub"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style29">Fellowship/Scholarship under:</td>
                <td>
                    <asp:Label ID="Label_Fellowship" runat="server" Text="Label_Fellowship"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style29">Languages Known:</td>
                <td>
                    <asp:Label ID="Label_Languages" runat="server" Text="Label_Languages"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style29">Precise Details of Research Experience(If any):</td>
                <td>
                    <asp:Label ID="Label_ResearchExp" runat="server" Text="Label_ResearchExp"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style30">Title of the proposed Research Topic:</td>
                <td class="auto-style4">
                    <asp:Label ID="Label_ResearchTopic" runat="server" Text="Label_ResearchTopic"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        Are you Currently Employed?
        <asp:Label ID="Label_CurrentlyEmp" runat="server" Text="Label_CurrentlyEmp"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style38">Name of the Instituition where employed:</td>
                <td class="auto-style44">
                    <asp:Label ID="Label_InstiName" runat="server" Text="Label_InstiName"></asp:Label>
                </td>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style34">&nbsp;</td>
                <td class="auto-style40">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style38">Designation:</td>
                <td class="auto-style44">
                    <asp:Label ID="Label_Designation" runat="server" Text="Label_Designation"></asp:Label>
                </td>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style34">&nbsp;</td>
                <td class="auto-style40">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style38">Period of Employment:</td>
                <td class="auto-style44">From:</td>
                <td class="auto-style46">
                    <asp:Label ID="Label_EmpFrom" runat="server" Text="Label_EmpFrom"></asp:Label>
                </td>
                <td class="auto-style34">To:</td>
                <td class="auto-style40">
                    <asp:Label ID="Label_EmpTo" runat="server" Text="Label_EmpTo"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style39">Type of Employment:</td>
                <td class="auto-style45">
                    <asp:Label ID="Label_TypeEmp" runat="server" Text="Label_TypeEmp"></asp:Label>
                </td>
                <td class="auto-style47"></td>
                <td class="auto-style37"></td>
                <td class="auto-style41"></td>
            </tr>
            <tr>
                <td class="auto-style39">Brief details about the nature of job:</td>
                <td class="auto-style45">
                    <asp:Label ID="Label_BriefDetails" runat="server" Text="Label_BriefDetails"></asp:Label>
                </td>
                <td class="auto-style47">&nbsp;</td>
                <td class="auto-style37">&nbsp;</td>
                <td class="auto-style41">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style39">Tel no Office:</td>
                <td class="auto-style45">
                    <asp:Label ID="Label_OfficeTelno" runat="server" Text="Label_OfficeTelno"></asp:Label>
                </td>
                <td class="auto-style47">&nbsp;</td>
                <td class="auto-style37">&nbsp;</td>
                <td class="auto-style41">&nbsp;</td>
            </tr>
        </table>
    </form>
    <p>
        Undertaking/Declaration:<br /> <br />
        I have carefully gone through the rules as prescribed under Ordiance-VIB and by the Board relating to the Doctorate of Philosphy(Ph.D) Course and I undertake to abide by them during the tenure of my research in the Department of <asp:Label ID="Label_Depart" runat="server" Text="Label"></asp:Label> &nbsp;University of Delhi. I am aware that disputes, if any, arising out of/or relating to any matter, whatsoever, concerning registeration/cancellation/submission of thesis or any other matter shall be subject to the exclusive jurisdiction of the competent courts in Delhi only.<br />
        I declare that I shall submit myself to the disciplinary jurisdiction of the authorities of the University who may be vested with the powers to exercise discipline under the Act, the Statutes, the Ordinances and the Rules that may be framed by the University/Board from time to time in this behalf.<br />
        <br />
    </p>
</body>
</html>
